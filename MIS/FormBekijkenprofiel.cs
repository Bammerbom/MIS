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
    public partial class FormBekijkenprofiel : Form
    {

        public FormBekijkenprofiel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void FormBekijkenprofiel_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndnummer = rnd.Next(0, 5);

            if (rndnummer == 0) { nul.Visible = true; Test.Visible = true; }
            else if (rndnummer == 1) { een.Visible = true; Test.Visible = true; }
            else if (rndnummer == 2) { twee.Visible = true; Test.Visible = true; }
            else if (rndnummer == 3) { drie.Visible = true; }
            else if (rndnummer == 4) { vier.Visible = true; }
            else if (rndnummer == 5) { vijf.Visible = true; }
        }
    } 

}
