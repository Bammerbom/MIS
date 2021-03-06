﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    public partial class ControlZoekenHeader : UserControl
    {
        bool Valid;
        public ControlZoekenHeader()
        {
            InitializeComponent();
        }

        #region Body events
        //Click event
        private void ZoekButton_Click(object sender, EventArgs e)
        {
            Panel panelB = FormHome.Home.panelB;
            //Als we in een profiel zitten
            if (panelB.Controls[0] is ControlBekijkenprofiel)
            {
                panelB.Controls.Clear();
                panelB.Controls.Add(FormHome.CZB);
            }

            Valid = CheckValid();
            if (Valid == true)
            {
                FormHome.CZB.DisposeResultaat();
                int FEcount = 0;
                Gebruiker[] gebruikers = Buildquery();

                foreach (Gebruiker GB in gebruikers)
                {
                    FormHome.CZB.MaakResultaat(GB, FEcount);
                    FEcount++;
                }
                if (!gebruikers.Any())
                {
                    FormHome.CZB.GeenResultaat();
                }
            }
            else
            {
                FormHome.CZB.DisposeResultaat();
                FormHome.CZB.FoutQuery();
            }
        }

        /// <summary>
        /// Zorgt dat er geldige parameters zijn gegeven.
        /// </summary>
        /// <returns>of het een geldige zoek functie is</returns>
        private bool CheckValid()
        {
            if (PrijsTextBox.Text != "")
            {
                try
                {
                    Convert.ToDouble(PrijsTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Foutieve prijs ingevuld.");
                    return false;
                }
            }

            int CheckedCount = 0;
            List<CheckBox> CBList = new List<CheckBox>()
                { HondCheckBox, KatCheckBox, KnaagdierCheckBox, VogelCheckBox, ReptielCheckBox, AmfibieCheckBox, InsectCheckBox, VisCheckBox};

            foreach (var y in CBList)
            {
                if (y.Checked)
                {
                    CheckedCount++;
                }
            }

            if (CheckedCount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Gebruiker[] Buildquery()
        {
            string dier = "", woonplaats;
            bool Verified, uitlaat, oppas;
            List<CheckBox> CBList = new List<CheckBox>()
                    { HondCheckBox, KatCheckBox, KnaagdierCheckBox, VogelCheckBox, ReptielCheckBox, AmfibieCheckBox, InsectCheckBox, VisCheckBox};

            foreach (CheckBox CB in CBList)
            {
                if (CB.Checked == true)
                {
                    dier = CB.Text;
                }
            }

            Verified = VerifiedCheckBox.Checked;
            uitlaat = UitlaatCheckBox.Checked;
            oppas = OppasCheckBox.Checked;
            woonplaats = ZoektextBox.Text;
            Gebruiker[] allegebruikers = GebruikerManager.AlleGebruikers();
            List<Gebruiker> filteredgebruikers = new List<Gebruiker>();

            foreach (var gebruiker in allegebruikers)
            {
                if (!gebruiker.diertypes.Contains(dier)) continue;
                if (woonplaats != "" && gebruiker.woonplaats != woonplaats) continue;
                if (PrijsTextBox.Text != "" && (gebruiker.vraagprijs > Convert.ToDouble(PrijsTextBox.Text))) continue;
                if (VerifiedCheckBox.Checked && !gebruiker.verified) continue;
                if (UitlaatCheckBox.Checked && !gebruiker.uitlaten) continue;
                if (OppasCheckBox.Checked && !gebruiker.oppassen) continue;
                filteredgebruikers.Add(gebruiker);
            }

            filteredgebruikers.Sort((Gebruiker a, Gebruiker b) =>
            {
                if (a.verified && !b.verified) return -1;
                if (b.verified && !a.verified) return 1;
                int Arating = ReviewManager.BerekenRating(a.userid);
                int Brating = ReviewManager.BerekenRating(b.userid);
                return Brating.CompareTo(Arating);
            });

            return filteredgebruikers.ToArray();
        }
        #endregion Body events

        #region Header events
        private void terugknop_Click(object sender, EventArgs e)
        {
            Panel panelB = FormHome.Home.panelB;
            //Als we in een profiel zitten
            if(panelB.Controls[0] is ControlBekijkenprofiel) {
                panelB.Controls.Clear();
                panelB.Controls.Add(FormHome.CZB);
            //Als we in het zoekscherm zitten
            }else if(panelB.Controls[0] is ControlZoekenBody) {
                //Als de zoeklijst al leeg is, ga terug naar inloggen
                if(FormHome.CZB.ResultaatList.Count == 0)
                {
                    FormHome.Home.NaarInloggen();
                    return;
                }
                //Anders, clear de zoeklijst
                FormHome.CZB.DisposeResultaat();
                List<CheckBox> CBList = new List<CheckBox>()
                    { HondCheckBox, KatCheckBox, KnaagdierCheckBox, VogelCheckBox, ReptielCheckBox, AmfibieCheckBox, InsectCheckBox, VisCheckBox,
                      VerifiedCheckBox, UitlaatCheckBox, OppasCheckBox};
                foreach (CheckBox cb in CBList) cb.Checked = false;
                ZoektextBox.Text = "";
                PrijsTextBox.Text = "";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormHome.Home.SetFullscreenMode(true);
            FormHome.Home.panelH.Controls.Clear();
            FormHome.Home.panelH.Controls.Add(new ControlVeranderProfiel());
        }
        /// <summary>
        /// zorgt ervoor dat oppas en uitlaat te gelijk gechecked zijn
        /// </summary>
        private void Extra_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                List<CheckBox> CBList = new List<CheckBox>()
                    {OppasCheckBox, UitlaatCheckBox};

                foreach (var Checkbox in CBList)
                {
                    if (Checkbox != box)
                    {
                        Checkbox.Checked = false;
                    }
                }
            }
        }

        /// <summary>
        /// Zorgt ervoor dat je maar 1 huisdiercheckbox kan checken
        /// </summary>
        private void Huisdierbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                List<CheckBox> CBList = new List<CheckBox>()
                    { HondCheckBox, KatCheckBox, KnaagdierCheckBox, VogelCheckBox, ReptielCheckBox, AmfibieCheckBox, InsectCheckBox, VisCheckBox};

                foreach (var Checkbox in CBList)
                {
                    if (Checkbox != box)
                    {
                        Checkbox.Checked = false;
                    }
                }
            }
        }

        private void pictureBoxAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.ShowDialog(); //ShowDialog locked alle andere forms zolang deze open is
        }

        #endregion Header events

    }
}
