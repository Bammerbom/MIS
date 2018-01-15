using System;
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
    public partial class ControlZoekenBody : UserControl
    {
        List<Control> ResultaatList = new List<Control>();
        public static bool GeenResultaatbool;
        public ControlZoekenBody()
        {
            InitializeComponent();
        }

        public void MaakResultaat(Gebruiker gebruiker, int pos)
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
            ProfielFotoPictureBox.Image = ProfielfotoManager.getProfielfoto(gebruiker.userid);
            ProfielFotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            panel.Controls.Add(ProfielFotoPictureBox);
            ResultaatList.Add(ProfielFotoPictureBox);
            // 
            // OppassenUitlaten
            // 
            string verzorgen = "";
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
            if (gebruiker.oppassen && gebruiker.uitlaten == false)
            {
                verzorgen = " verzorgen.";
            }
            else if (gebruiker.oppassen == false && gebruiker.uitlaten)
            {
                verzorgen = " uitlaten.";
            }
            else if (gebruiker.oppassen && gebruiker.uitlaten)
            {
                verzorgen = " verzorgen en uitlaten.";
            }
            OppassenUitlaten.Text = "Kan een " + gebruiker.diertypes + verzorgen;
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

        private void profiel_ClickEvent(Gebruiker GB)
        {
            Panel panel = FormHome.Home.panelB;
            panel.Controls.Clear();
            panel.Controls.Add(new ControlBekijkenprofiel(GB.userid));
        }

        public void GeenResultaat()
        {
            var ErrorLabel = new Label();
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            ErrorLabel.Location = new Point(410, 10);
            ErrorLabel.Name = "ResultaatLabel";
            ErrorLabel.Size = new Size(180, 20);
            ErrorLabel.TabIndex = 57;
            ErrorLabel.Text = "Geen Zoekresultaten";
            panel.Controls.Add(ErrorLabel);
            ResultaatList.Add(ErrorLabel);
            GeenResultaatbool = true;
        }

        public void FoutQuery()
        {
            var ErrorLabel = new Label();
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            ErrorLabel.Location = new Point(400, 10);
            ErrorLabel.Name = "ResultaatLabel";
            ErrorLabel.Size = new Size(180, 20);
            ErrorLabel.TabIndex = 57;
            ErrorLabel.Text = "U moet een dier selecteren.";
            panel.Controls.Add(ErrorLabel);
            ResultaatList.Add(ErrorLabel);
            GeenResultaatbool = true;
        }

        public void DisposeResultaat()
        {
            foreach (var DR in ResultaatList)
            {
                DR.Dispose();
            }
            ResultaatList.Clear();
            GC.Collect();
        }
    }
}
