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
    public partial class FormMakenprofiel : Form
    {
        public FormMakenprofiel()
        {
            InitializeComponent();
        }
        private void ProfielAanmakenButton_Click(object sender, EventArgs e)
        {
            if (!HondCheckbox.Checked && !KatCheckbox.Checked && !ReptielCheckbox.Checked && !AmfibieCheckbox.Checked && !VissenCheckbox.Checked && InsectCheckbox.Checked && !KnaagdierCheckbox.Checked && !VogelCheckbox.Checked)
            {
                MessageBox.Show("Geef aan met welke dieren je ervaring hebt");
            }
            else if (!OppasCheckbox.Checked && !UitlaatCheckbox.Checked)
            {
                MessageBox.Show("Geef aan of je op wil passen, uit wil laten of geïntresseerd  bent in beide");
            }
            else if (VoornaamTextbox.Text == "")
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
                 
                List<CheckBox> CBList = new List<CheckBox>()
                    { HondCheckbox, KatCheckbox, KnaagdierCheckbox, VogelCheckbox, ReptielCheckbox, AmfibieCheckbox, InsectCheckbox, VissenCheckbox};
                string diertypes = "";
                foreach (var checkbox in CBList)
                {
                    if (checkbox.Checked)
                    {
                        diertypes += checkbox.Text + ", ";
                    }
                }
                if(diertypes != "") diertypes = diertypes.Substring(0, diertypes.Length - 2);
                    
                var gebruiker = new Gebruiker
                {
                    voornaam = VoornaamTextbox.Text,
                    achternaam = AchternaamTextbox.Text,
                    woonplaats = WoonplaatsTextbox.Text,
                    vraagprijs = Convert.ToDouble(VraagprijsTextbox.Text),
                    verified = PremiumCheckbox.Checked,
                    admin = false,
                    diertypes = diertypes,
                    oppassen = OppasCheckbox.Checked,
                    uitlaten = UitlaatCheckbox.Checked,
                    overmij = OverMijTextbox.Text,    
                };
                GebruikerManager.GebruikerToevoegen(gebruiker);
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

        private void VraagprijsTextbox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(VraagprijsTextbox.Text, " ^[0-9]"))
            {
                VraagprijsTextbox.Text = "";
            }
        }

        private void VraagprijsTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit (e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
 
