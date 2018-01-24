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
        List<Control> LoadedReviews = new List<Control>();

        public ControlBekijkenprofiel(int userid)
        {
            InitializeComponent();
            UserId = userid;
        }

        private void FormBekijkenprofiel_Load(object sender, EventArgs e)
        {
            var gebruiker = GebruikerManager.GebruikerOpvragen(UserId);
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
            // LogedIn features weg halen
            if (!LoginCheck())
            {
                List<Control> ReviewPItems = new List<Control>()
                    {TitelLabel, BodyLabel, SchrijfhierLabel, OLijnLabel, ErrorLabel, ASterLabel, RtitelTextBox, RbodyTextBox,
                    Ster1CheckBox, Ster2CheckBox, Ster3CheckBox, Ster4CheckBox, Ster5CheckBox, PReviewButton, DiscardButton};

                foreach (var Item in ReviewPItems)
                {
                    Item.Visible = false;
                }
            }
            //reviews laden
            ReviewLoad();
        }

        private void ReviewLoad()
        {
            foreach (var Item in LoadedReviews)
            {
                Item.Dispose();
            }
            LoadedReviews.Clear();

            var Lreviews = ReviewManager.ReviewsOppasser(UserId).ToList<Review>();

            Lreviews.Sort((Review a, Review b) =>
            {
                if (LoginCheck())
                {
                    Gebruiker jezelf = (Gebruiker)SessionManager.GetCurrentUser();
                    if (a.reviewerid == jezelf.userid && b.reviewerid == jezelf.userid) return b.reviewid.CompareTo(a.reviewid);
                    if (a.reviewerid == jezelf.userid) return -1;
                    if (b.reviewerid == jezelf.userid) return 1;
                }
                return b.reviewid.CompareTo(a.reviewid);
            });
            foreach (var Item in Lreviews)
            {
                if (LoginCheck() && Item.reviewerid == ((Gebruiker)SessionManager.GetCurrentUser()).userid)
                {
                    DiscardButton.Visible = true;
                }
            }

            int RVcount = 0;
            foreach (Review RV in Lreviews)
            {
                ReviewPlaatser(RV, RVcount);
                RVcount++;
            }
        }

        private bool LoginCheck()
        {
            return SessionManager.IsLoggedIn();
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
                ReviewLoad();
            }
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            var Lreviews = ReviewManager.ReviewsOppasser(UserId).ToList<Review>();
            int reviewerid = ((Gebruiker)SessionManager.GetCurrentUser()).userid;

            foreach (var Item in Lreviews)
            {
                if (Item.reviewerid != reviewerid) continue;
                ReviewManager.ReviewVerwijderen(Item.reviewid);
            }
            DiscardButton.Visible = false;
            ReviewLoad();
        }

        private bool CheckValid()
        {
            if (RtitelTextBox.Text == "")
            {
                ErrorLabel.Text = "Je moet een titel invullen!";
                return false;
            }
            if (RtitelTextBox.Text.Count() > 20)
            {
                ErrorLabel.Text = "Je mag niet meer dan 20 karakters in de titel gebruiken.";
                return false;
            }
            if (RbodyTextBox.Text == "")
            {
                ErrorLabel.Text = "Je moet een review schrijven!";
                return false;
            }
            if (RtitelTextBox.Text.Count() > 320)
            {
                ErrorLabel.Text = "Je mag niet meer dan 320 karakter in je review gebruiken.";
                return false;
            }

            bool IsChecked = false;
            List<CheckBox> CBList = new List<CheckBox>()
                    {Ster1CheckBox, Ster2CheckBox, Ster3CheckBox, Ster4CheckBox, Ster5CheckBox};
            foreach(var CB in CBList)
            {
                if (!CB.Checked) continue;
                IsChecked = true;
            }
            if (!IsChecked)
            {
                ErrorLabel.Text = "Je moet een rating geven!";
                return false;
            }

            ErrorLabel.Text = "";
            return true;
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
            int Y = 0;
            if (LoginCheck()) Y = 800;
            else Y = 525;

            // "FIX" een feature van windows forms waar posities relatief zijn tot de autoscroll positie
            // PS. Dit is bonkers irritant en we hebben hier minstens 1,5 uur naar gezocht
            Y = Y + panel1.AutoScrollPosition.Y;

            // 
            // RnameLabel
            // 
            var RnameLabel = new Label();
            RnameLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            RnameLabel.Location = new Point(268, 96 + Y + BlokY);
            RnameLabel.Name = "RnameLabel";
            RnameLabel.Size = new Size(157, 34);
            RnameLabel.TabIndex = 90;
            RnameLabel.Text = GebruikerManager.GebruikerOpvragen(review.reviewerid).voornaam + " " + GebruikerManager.GebruikerOpvragen(review.reviewerid).achternaam;
            panel1.Controls.Add(RnameLabel);
            LoadedReviews.Add(RnameLabel);
            // 
            // RSterPictureBox
            // 
            Bitmap[] Ster = new Bitmap[6]
                {Properties.Resources.ster0, Properties.Resources.ster1, Properties.Resources.ster2, Properties.Resources.ster3, Properties.Resources.ster4, Properties.Resources.ster5};
            var RSterPictureBox = new PictureBox();
            RSterPictureBox.Location = new Point(267, 62 + Y + BlokY);
            RSterPictureBox.Name = "RSterPictureBox";
            RSterPictureBox.Size = new Size(157, 31);
            RSterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RSterPictureBox.TabIndex = 88;
            RSterPictureBox.TabStop = false;
            RSterPictureBox.Image = Ster[review.rating];
            panel1.Controls.Add(RSterPictureBox);
            LoadedReviews.Add(RSterPictureBox);
            // 
            // RProfilePictureBox
            // 
            var RProfilePictureBox = new PictureBox();
            RProfilePictureBox.InitialImage = null;
            RProfilePictureBox.Location = new Point(172, 62 + Y + BlokY);
            RProfilePictureBox.Name = "RProfilePictureBox";
            RProfilePictureBox.Size = new Size(90, 90);
            RProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RProfilePictureBox.TabIndex = 87;
            RProfilePictureBox.TabStop = false;
            RProfilePictureBox.Image = ProfielfotoManager.getProfielfoto(review.reviewerid);
            panel1.Controls.Add(RProfilePictureBox);
            LoadedReviews.Add(RProfilePictureBox);
            // 
            // RTitelLabel
            // 
            var RTitelLabel = new Label();
            RTitelLabel.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            RTitelLabel.Location = new Point(427, 66 + Y + BlokY);
            RTitelLabel.Name = "RTitelLabel";
            RTitelLabel.Size = new Size(374, 23);
            RTitelLabel.TabIndex = 86;
            RTitelLabel.Text = review.title;
            panel1.Controls.Add(RTitelLabel);
            LoadedReviews.Add(RTitelLabel);
            // 
            // RBodyLabel
            // 
            var RBodyLabel = new Label();
            RBodyLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            RBodyLabel.Location = new Point(427, 94 + Y + BlokY);
            RBodyLabel.Name = "RBodyLabel";
            RBodyLabel.Size = new Size(374, 158);
            RBodyLabel.TabIndex = 72;
            RBodyLabel.Text = review.body;
            panel1.Controls.Add(RBodyLabel);
            LoadedReviews.Add(RBodyLabel);
        }
    }
}
