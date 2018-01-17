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
    public partial class ControlVeranderProfiel : UserControl
    {
        public ControlVeranderProfiel()
        {
            InitializeComponent();
        }

        private void ControlVeranderProfiel_Load(object sender, EventArgs e)
        {
            Gebruiker gebruiker = (Gebruiker) SessionManager.GetCurrentUser();
            WoonplaatsTextBox.Text = gebruiker.woonplaats;
            OpassenCheckBox.Checked = gebruiker.oppassen;
            UitlatenCheckBox.Checked = gebruiker.uitlaten;
            PrijsTextBox.Text = Convert.ToString(gebruiker.vraagprijs);
            bool[] diertypes = GebruikerManager.DiertypesNaarBool(gebruiker.diertypes);
            KatCheckBox.Checked = diertypes[1];
            HondCheckBox.Checked = diertypes[0];
            KnaagdierCheckBox.Checked = diertypes[2];
            VogelCheckBox.Checked = diertypes[3];
            ReptielCheckBox.Checked = diertypes[4];
            AmfibieCheckBox.Checked = diertypes[5];
            InsectCheckBox.Checked = diertypes[6];
            VisCheckBox.Checked = diertypes[7];
            OvermijTextBox.Text = gebruiker.overmij;
            NaamTextBox.Text = gebruiker.voornaam;
                AchternaamTextBox.Text = gebruiker.achternaam;
            WachtwoordTextBox.Text = gebruiker.password;
            EmailTextBox.Text = gebruiker.email;

        }

        private void Klaar_Click(object sender, EventArgs e)
        {
            Gebruiker gebruiker = (Gebruiker)SessionManager.GetCurrentUser();
            gebruiker.woonplaats = WoonplaatsTextBox.Text;
            gebruiker.oppassen = OpassenCheckBox.Checked;
            gebruiker.uitlaten = UitlatenCheckBox.Checked;
            gebruiker.vraagprijs = Convert.ToDouble(PrijsTextBox.Text);
            gebruiker.overmij = OvermijTextBox.Text;
            gebruiker.voornaam = NaamTextBox.Text;
            gebruiker.achternaam = AchternaamTextBox.Text;
            gebruiker.password = WachtwoordTextBox.Text;
            gebruiker.email = EmailTextBox.Text;
            bool[] diertypes = new bool[8];
            diertypes[0] = HondCheckBox.Checked;
            diertypes[1] = KatCheckBox.Checked;
            diertypes[3] = VogelCheckBox.Checked;
            diertypes[4] = ReptielCheckBox.Checked;
            diertypes[5] = AmfibieCheckBox.Checked;
            diertypes[6] = InsectCheckBox.Checked;
            diertypes[7] = VisCheckBox.Checked;
            diertypes[2] = KnaagdierCheckBox.Checked;
            gebruiker.diertypes = GebruikerManager.DiertypesVanBool(diertypes);

            GebruikerManager.GebruikerWijzigen(gebruiker);
            MessageBox.Show("Uw veranderingen zijn opgeslagen");
            FormHome.Home.NaarZoeken();
        }

        private void AnnulerenButton_Click(object sender, EventArgs e)
        {
            FormHome.Home.NaarZoeken();
        }
    }
}
