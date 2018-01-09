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
        }

        private void OverMijTextbox_TextChanged(object sender, EventArgs e)
        {
            if (OverMijTextbox.Text == "")
            {
                MessageBox.Show("Vertel nog wat over jezelf");
            }
        }
    }
}
 
