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
            RatingPictureBox.Image = Ster[gebruiker.rating];
            //Profielfoto
            Profielfoto.Image = ProfielfotoManager.getProfielfoto(gebruiker.userid);
        }
    }
}
