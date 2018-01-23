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
    public partial class ControlBekijkenprofiel : UserControl
    {
        private int UserId;
        private int RVcount;

        public ControlBekijkenprofiel(int userid)
        {
            InitializeComponent();
            UserId = userid;
        }

        private void FormBekijkenprofiel_Load(object sender, EventArgs e)
        {
            var gebruiker = GebruikerManager.GebruikerOpvragen(UserId);
            var reviews = ReviewManager.ReviewsOppasser(UserId);
            Naam.Text = gebruiker.voornaam + " " + gebruiker.achternaam;
            this.Text = "Profiel van " + gebruiker.voornaam + " " + gebruiker.achternaam;
            Adres.Text = gebruiker.woonplaats;
            if (gebruiker.oppassen && gebruiker.uitlaten == false)
            {
                OppassenUitlatenLabel.Text = "Kan passen op:";
            }
            else if (gebruiker.oppassen == false && gebruiker.uitlaten)
            {
                OppassenUitlatenLabel.Text = "Kan de volgende dieren uitlaten:";
            }
            else if (gebruiker.oppassen && gebruiker.uitlaten)
            {
                OppassenUitlatenLabel.Text = "Kan op de volgende dieren passen en is bereid om ze uit te laten:";
            }
            Kanpassenop.Text = gebruiker.diertypes;
            Overmijinfo.Text = gebruiker.overmij;
            Prijs.Text = "Prijs per dag: €" + gebruiker.vraagprijs;
            //Rating
            Bitmap[] Ster = new Bitmap[6] 
                {Properties.Resources.ster0, Properties.Resources.ster1, Properties.Resources.ster2, Properties.Resources.ster3, Properties.Resources.ster4, Properties.Resources.ster5};
            RatingPictureBox.Image = Ster[ReviewManager.BerekenRating(UserId)];
            //Profielfoto
            Profielfoto.Image = ProfielfotoManager.getProfielfoto(gebruiker.userid);
            //reviews laden
            foreach (Review RV in reviews)
            {
                ReviewPlaatser(RV, RVcount);
                RVcount++;
            }
        }

        private void PReviewButton_Click(object sender, EventArgs e)
        {
            if (CheckValid())
            {
                List<CheckBox> CBList = new List<CheckBox>()
                    {Ster1CheckBox, Ster2CheckBox, Ster3CheckBox, Ster4CheckBox, Ster5CheckBox};
                int CBcount = 0;
                Review NewReview = new Review();
                NewReview.title = RtitelTextBox.Text;
                NewReview.body = RbodyTextBox.Text;
                NewReview.reviewedid = UserId;
                NewReview.reviewerid = ((Gebruiker) SessionManager.GetCurrentUser()).userid;
                foreach (var CB in CBList)
                {
                    CBcount++;
                    if (CB.Checked)
                    {
                        NewReview.rating = CBcount;
                        break;
                    }
                }
                ReviewManager.ReviewToevoegen(NewReview);
            }
            else MessageBox.Show("False"); // error
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {

        }

        private bool CheckValid()
        {
            bool TIsValid = false;
            bool BIsValid = false;
            bool IsChecked = false;

            if (RtitelTextBox.Text != "" && RtitelTextBox.Text.Count() <= 40) TIsValid = true;
            if (RbodyTextBox.Text != "" && RtitelTextBox.Text.Count() <= 320) BIsValid = true;

            List<CheckBox> CBList = new List<CheckBox>()
                    {Ster1CheckBox, Ster2CheckBox, Ster3CheckBox, Ster4CheckBox, Ster5CheckBox};
            foreach(var CB in CBList)
            {
                if (CB.Checked != true) continue;
                IsChecked = true;
            }

            if (IsChecked == true && TIsValid == true && BIsValid == true) return true;
            else return false;
        }

        private void SterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                List<CheckBox> CBList = new List<CheckBox>()
                    {Ster1CheckBox, Ster2CheckBox, Ster3CheckBox, Ster4CheckBox, Ster5CheckBox};

                foreach (var Checkbox in CBList)
                {
                    if (Checkbox != box) Checkbox.Checked = false;
                }
            }
        }

        /// <summary>
        /// Plaatst de review aan de hand van het positie nummer
        /// </summary>
        /// <param name="review"></param>
        /// <param name="pos"></param>
        public void ReviewPlaatser(Review review, int pos)
        {
            int BlokY = (pos * 220);

            // 
            // RnameLabel
            // 
            var RnameLabel = new Label();
            RnameLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            RnameLabel.Location = new Point(268, 896 * BlokY);
            RnameLabel.Name = "RnameLabel";
            RnameLabel.Size = new Size(157, 34);
            RnameLabel.TabIndex = 90;
            RnameLabel.Text = GebruikerManager.GebruikerOpvragen(review.reviewerid).voornaam;
            panel1.Controls.Add(RnameLabel);
            // 
            // RSterPictureBox
            // 
            Bitmap[] Ster = new Bitmap[6]
                {Properties.Resources.ster0, Properties.Resources.ster1, Properties.Resources.ster2, Properties.Resources.ster3, Properties.Resources.ster4, Properties.Resources.ster5};
            var RSterPictureBox = new PictureBox();
            RSterPictureBox.Location = new Point(267, 862 * BlokY);
            RSterPictureBox.Name = "RSterPictureBox";
            RSterPictureBox.Size = new Size(157, 31);
            RSterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RSterPictureBox.TabIndex = 88;
            RSterPictureBox.TabStop = false;
            RSterPictureBox.Image = Ster[review.rating];
            panel1.Controls.Add(RSterPictureBox);
            // 
            // RProfilePictureBox
            // 
            var RProfilePictureBox = new PictureBox();
            RProfilePictureBox.InitialImage = null;
            RProfilePictureBox.Location = new Point(172, 862 * BlokY);
            RProfilePictureBox.Name = "RProfilePictureBox";
            RProfilePictureBox.Size = new Size(90, 90);
            RProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RProfilePictureBox.TabIndex = 87;
            RProfilePictureBox.TabStop = false;
            RProfilePictureBox.Image = ProfielfotoManager.getProfielfoto(review.reviewerid);
            panel1.Controls.Add(RProfilePictureBox);
            // 
            // RTitelLabel
            // 
            var RTitelLabel = new Label();
            RTitelLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            RTitelLabel.Location = new Point(427, 862 * BlokY);
            RTitelLabel.Name = "RTitelLabel";
            RTitelLabel.Size = new Size(374, 23);
            RTitelLabel.TabIndex = 86;
            RTitelLabel.Text = review.title;
            panel1.Controls.Add(RTitelLabel);
            // 
            // RBodyLabel
            // 
            var RBodyLabel = new Label();
            RBodyLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            RBodyLabel.Location = new Point(427, 894 * BlokY);
            RBodyLabel.Name = "RBodyLabel";
            RBodyLabel.Size = new Size(374, 158);
            RBodyLabel.TabIndex = 72;
            RBodyLabel.Text = review.body;
            panel1.Controls.Add(RBodyLabel);
        }
    }
}
