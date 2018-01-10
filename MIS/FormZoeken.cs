using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    public partial class FormZoeken : Form
    {
        bool Valid;
        public FormZoeken()
        {
            InitializeComponent();
        }

        //Click event
        private void ZoekButton_Click(object sender, EventArgs e)
        {
            Valid = CheckValid();
            if (Valid == true)
            {
                Gebruiker[] gebruikers = Buildquery();

            }
            else
            {
                MessageBox.Show("ERROR");
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
            Gebruiker[] allegebruikers = DatabaseManager.AlleGebruikers();
            List<Gebruiker> filteredgebruikers = new List<Gebruiker>();

            foreach (var gebruiker in allegebruikers)
            {
                if (!gebruiker.diertypes.Contains(dier)) continue;
                if (woonplaats != "" && gebruiker.woonplaats != woonplaats) continue;
                if (PrijsTextBox.Text != "" && (gebruiker.vraagprijs > Convert.ToDouble(PrijsTextBox.Text))) continue;
                if (VerifiedCheckBox.Checked && !gebruiker.verified) continue;
                if (UitlaatCheckBox.Checked  && !gebruiker.uitlaten) continue;
                if (OppasCheckBox.Checked && !gebruiker.oppassen) continue;
                filteredgebruikers.Add(gebruiker);
            }

            filteredgebruikers.Sort((Gebruiker a, Gebruiker b) =>
            {
                if (a.verified) return -1;
                if (b.verified) return 1;
                return -1;
            });

            return filteredgebruikers.ToArray();
        }  
    }
}
