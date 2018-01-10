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
    public partial class FormProfiel : Form
    {
        public FormProfiel()
        {
            InitializeComponent();
        }
        private void ProfielAanmakenButton_Click(object sender, EventArgs e)
        {
            if (VoornaamTextbox.Text == "")
            {
                MessageBox.Show("Je hebt 1 of meerdere velden leeggelaten!");
            }
            else if (AchternaamTextbox.Text == "")
            {
                MessageBox.Show("Je hebt 1 of meerdere velden leeggelaten!");
            }
            else if (WoonplaatsTextbox.Text == "")
            {
                MessageBox.Show("Je hebt 1 of meerdere velden leeggelaten!");
            }
            else if(VraagprijsTextbox.Text == "" && double.TryParse(VraagprijsTextbox.Text, out var n))
            {
                MessageBox.Show("Je hebt 1 of meerdere velden leeggelaten!");
            }
            else if (OverMijTextbox.Text == "")
            {
                MessageBox.Show("Vertel nog wat over jezelf");
            }
            else
            {
                var gebruiker = new Gebruiker
                {
                    voornaam = VoornaamTextbox.Text,
                    achternaam = AchternaamTextbox.Text,
                    woonplaats = WoonplaatsTextbox.Text,
                    vraagprijs = Convert.ToDouble(VraagprijsTextbox.Text),
                    verified = PremiumCheckbox.Checked,
                    admin = false,
                    diertypes = "",
                    oppassen = OppasCheckbox.Checked,
                    uitlaten = UitlaatCheckbox.Checked
                };
                DatabaseManager.GebruikerToevoegen(gebruiker);
                MessageBox.Show("De gebruiker is toegevoegd!");
            }


        }

        private void PremiumCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PremiumCheckbox.Checked)
            {
                PremiumCheckbox.Text = "Ja, ik wil graag gebruik maken van de voordelen van een premium gebruiker";
            }
            else
            {
                PremiumCheckbox.Text = "Nee, ik wil geen gebruik maken van de voordelen van een premium gebruiker";
            }
        }
    }
}
 
