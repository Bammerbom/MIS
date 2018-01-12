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
        List<Control> ResultaatList = new List<Control>();
        bool Valid;
        public FormZoeken()
        {
            InitializeComponent();
        }

        private void FormZoeken_Load(object sender, EventArgs e)
        {
        }

        #region Zoeken
        //Click event
        private void ZoekButton_Click(object sender, EventArgs e)
        {
            Valid = CheckValid();
            if (Valid == true)
            {
                DisposeResultaat();
                int FEcount = 0;
                Gebruiker[] gebruikers = Buildquery();
                
                foreach(Gebruiker GB in gebruikers)
                {
                    MaakResultaat(GB, FEcount);
                    FEcount++;
                }
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
                if (a.verified && !b.verified) return -1;
                if (b.verified && !a.verified) return 1;
                return b.rating.CompareTo(a.rating);
            });

            return filteredgebruikers.ToArray();
        }
        #endregion Zoeken

        public void MaakResultaat(Gebruiker gebruiker , int pos)
        {
            
            //Globale variabelen
            int H = 100;
            int W = 400;
            int posX = Convert.ToInt32(500 - 0.5 * W);
            int posY = 0;
            int bufferY = 15;
            int bufferX = 10;

            //Per blok variabelen
            int blokX = posX;
            int blokY = posY + H * pos;

            // 
            // ResultaatLabel
            // 
            var ResultaatLabel = new Label();
            ResultaatLabel.Click += delegate
            {
                profiel_ClickEvent(gebruiker);
            };
            ResultaatLabel.AutoSize = true;
            ResultaatLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            ResultaatLabel.Location = new Point(blokX + 70 + bufferX, blokY + bufferY);
            ResultaatLabel.Name = "ResultaatLabel";
            ResultaatLabel.Size = new Size(180, 20);
            ResultaatLabel.TabIndex = 57;
            ResultaatLabel.Text = gebruiker.voornaam + " " + gebruiker.achternaam;
            panel.Controls.Add(ResultaatLabel);
            ResultaatList.Add(ResultaatLabel);
            // 
            // ProfielFotoPictureBox
            // 
            var ProfielFotoPictureBox = new PictureBox();
            ProfielFotoPictureBox.Click += delegate
            {
                profiel_ClickEvent(gebruiker);
            };
            ProfielFotoPictureBox.Location = new Point(blokX, blokY + bufferY);
            ProfielFotoPictureBox.Name = "ProfielFotoPictureBox";
            ProfielFotoPictureBox.Size = new Size(70, 70);
            ProfielFotoPictureBox.TabIndex = 58;
            ProfielFotoPictureBox.TabStop = false;
            ProfielFotoPictureBox.Image = Properties.Resources.stock_dierenliefhebber;
            ProfielFotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            panel.Controls.Add(ProfielFotoPictureBox);
            ResultaatList.Add(ProfielFotoPictureBox);
            // 
            // OppassenUitlaten
            // 
            var OppassenUitlaten = new Label();
            OppassenUitlaten.Click += delegate
            {
                profiel_ClickEvent(gebruiker);
            };
            OppassenUitlaten.AutoSize = true;
            OppassenUitlaten.Location = new Point(blokX + 70 + bufferX, blokY + bufferY + 20);
            OppassenUitlaten.Name = "OppassenUitlaten";
            OppassenUitlaten.Size = new Size(136, 13);
            OppassenUitlaten.TabIndex = 59;
            OppassenUitlaten.Text = "Kan een "+ gebruiker.diertypes + " verzorgen.";
            panel.Controls.Add(OppassenUitlaten);
            ResultaatList.Add(OppassenUitlaten);
            // 
            // RatingPictureBox
            // 
            var RatingPictureBox = new PictureBox();
            RatingPictureBox.Click += delegate
            {
                profiel_ClickEvent(gebruiker);
            };
            RatingPictureBox.Location = new Point(blokX + 70 + bufferX, blokY + bufferY + 20 + 15 + 15);
            RatingPictureBox.Name = "RatingPictureBox";
            RatingPictureBox.Size = new Size(100, 20);
            RatingPictureBox.TabIndex = 60;
            RatingPictureBox.TabStop = false;
            Bitmap[] images = new Bitmap[]{ Properties.Resources.ster0, Properties.Resources.ster1,
                Properties.Resources.ster2, Properties.Resources.ster3, Properties.Resources.ster4, Properties.Resources.ster5};
            RatingPictureBox.Image = images[gebruiker.rating];
            RatingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            panel.Controls.Add(RatingPictureBox);
            ResultaatList.Add(RatingPictureBox);
            // 
            // VerifiedPicktureBox
            // 
            if (gebruiker.verified)
            {
                var VerifiedPicktureBox = new PictureBox();
                VerifiedPicktureBox.Click += delegate
                {
                    profiel_ClickEvent(gebruiker);
                };
                VerifiedPicktureBox.Location = new Point(blokX + 70 + bufferX + ResultaatLabel.Width, blokY + bufferY);
                VerifiedPicktureBox.Name = "VerifiedPicktureBox";
                VerifiedPicktureBox.Size = new Size(20, 20);
                VerifiedPicktureBox.TabIndex = 61;
                VerifiedPicktureBox.TabStop = false;
                VerifiedPicktureBox.Image = Properties.Resources.checkbox;
                VerifiedPicktureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                panel.Controls.Add(VerifiedPicktureBox);
                ResultaatList.Add(VerifiedPicktureBox);
            } 
            // 
            // Locatielabel
            // 
            var Locatielabel = new Label();
            Locatielabel.Click += delegate
            {
                profiel_ClickEvent(gebruiker);
            };
            Locatielabel.AutoSize = true;
            Locatielabel.Location = new Point(blokX + 70 + bufferX, blokY + bufferY + 20 + 15);
            Locatielabel.Name = "Locatielabel";
            Locatielabel.Size = new Size(51, 13);
            Locatielabel.TabIndex = 62;
            Locatielabel.Text = gebruiker.woonplaats + " - €" + gebruiker.vraagprijs + " per dag";
            panel.Controls.Add(Locatielabel);
            ResultaatList.Add(Locatielabel);
        }

        private void DisposeResultaat()
        {
            foreach(var DR in ResultaatList)
            {
                DR.Dispose();
            }
        }

        private void profiel_ClickEvent(Gebruiker GB)
        {
            var Bekijkenprofiel = new FormBekijkenprofiel(GB.userid);
            Bekijkenprofiel.Show();
        }
    }
}
