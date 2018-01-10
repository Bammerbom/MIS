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

        private void Vertified_Click(object sender, EventArgs e)
        {

        }

        private void vier_Click(object sender, EventArgs e)
        {

        }

        private void drie_Click(object sender, EventArgs e)
        {

        }

        private void twee_Click(object sender, EventArgs e)
        {

        }

        private void een_Click(object sender, EventArgs e)
        {

        }

        private void nul_Click(object sender, EventArgs e)
        {

        }

        private void Dagopvang_Click(object sender, EventArgs e)
        {

        }

        private void Logeren_Click(object sender, EventArgs e)
        {

        }

        private void Dienstentitel_Click(object sender, EventArgs e)
        {

        }

        private void Woninginfo_Click(object sender, EventArgs e)
        {

        }

        private void Woningtitel_Click(object sender, EventArgs e)
        {

        }

        private void Overmijinfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Overmij_Click(object sender, EventArgs e)
        {

        }

        private void Kanpassenop_Click(object sender, EventArgs e)
        {

        }

        private void Adres_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Naam_Click(object sender, EventArgs e)
        {

        }

        private void vijf_Click(object sender, EventArgs e)
        {

        }
    } 

}
