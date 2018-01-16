using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MIS
{
    public partial class FormAdmin : Form
    {
        DataTable table;
        int? CurrentRow = null;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            this.table = GetDataTable();
            AdminDatagrid.DataSource = table;
            AdminDatagrid.Columns[0].Width = 50;
            AdminDatagrid.Columns[1].Width = 135;
            AdminDatagrid.Columns[2].Width = 135;
            AdminDatagrid.Columns[3].Width = 110;
            AdminDatagrid.Columns[4].Width = 70;
            AdminDatagrid.Columns[5].Width = 70;
            AdminDatagrid.Columns[6].Width = 70;
            AdminDatagrid.Columns[7].Width = 70;
            AdminDatagrid.Columns[8].Width = 70;
            AdminDatagrid.Columns[9].Width = 160;
            AdminDatagrid.Columns[10].Width = 50;
        }

        public DataTable GetDataTable()
        {
            //Maak een nieuwe tabel
            DataTable table = new DataTable();
            table.Columns.Add("userid", typeof(int));
            table.Columns.Add("voornaam", typeof(string));
            table.Columns.Add("achternaam", typeof(string));
            table.Columns.Add("woonplaats", typeof(string));
            table.Columns.Add("verified", typeof(bool));
            table.Columns.Add("admin", typeof(bool));
            table.Columns.Add("vraagprijs", typeof(double));
            table.Columns.Add("oppassen", typeof(bool));
            table.Columns.Add("uitlaten", typeof(bool));
            table.Columns.Add("diertypes", typeof(string));
            table.Columns.Add("rating", typeof(int));

            //Data toevoegen
            foreach (var gebruiker in DatabaseManager.AlleGebruikers())
            {
                table.Rows.Add(gebruiker.userid, gebruiker.voornaam, gebruiker.achternaam, gebruiker.woonplaats, gebruiker.verified, gebruiker.admin, gebruiker.vraagprijs, gebruiker.oppassen, gebruiker.uitlaten, gebruiker.diertypes, gebruiker.rating);
            }

            return table;
        }
        private void AdminDatagrid_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            CurrentRow = e.RowIndex;
            List<CheckBox> CBListAdmin = new List<CheckBox>()
                    { HondCheckboxAdmin, KatCheckboxAdmin, KnaagdierCheckboxAdmin, VogelCheckboxAdmin, ReptielCheckboxAdmin, AmfibieCheckboxAdmin, InsectCheckboxAdmin, VissenCheckboxAdmin};
            VoornaamAdmin.Text = AdminDatagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            AchternaamAdmin.Text = AdminDatagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            WoonplaatsAdmin.Text = AdminDatagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            VraagprijsAdmin.Text = AdminDatagrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            RatingAdmin.Text = AdminDatagrid.Rows[e.RowIndex].Cells[10].Value.ToString();
            OppassenAdmin.Checked = (bool) AdminDatagrid.Rows[e.RowIndex].Cells[7].Value;
            UitlatenAdmin.Checked = (bool)AdminDatagrid.Rows[e.RowIndex].Cells[8].Value;
            VerifiedAdmin.Checked = (bool)AdminDatagrid.Rows[e.RowIndex].Cells[4].Value;
            AdminAdmin.Checked = (bool)AdminDatagrid.Rows[e.RowIndex].Cells[5].Value;

            foreach (CheckBox cb in CBListAdmin) cb.Checked = false;
            string dieren = (string) AdminDatagrid.Rows[e.RowIndex].Cells[9].Value;
            foreach(string dier in dieren.Split(", ".ToCharArray()))
            {
                switch (dier)
                {
                    case "Hond":
                        HondCheckboxAdmin.Checked = true;
                        break;
                    case "Kat":
                        KatCheckboxAdmin.Checked = true;
                        break;
                    case "Knaagdier":
                        KnaagdierCheckboxAdmin.Checked = true;
                        break;
                    case "Vogel":
                        VogelCheckboxAdmin.Checked = true;
                        break;
                    case "Reptiel":
                        ReptielCheckboxAdmin.Checked = true;
                        break;
                    case "Amfibie":
                        AmfibieCheckboxAdmin.Checked = true;
                        break;
                    case "Insect":
                        InsectCheckboxAdmin.Checked = true;
                        break;
                    case "Vissen":
                        VissenCheckboxAdmin.Checked = true;
                        break;
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Als de gebruiker geen rij selecteerd, ga dan zeuren
            if (CurrentRow == null)
            {
                MessageBox.Show("Je hebt geen row geselecteerd");
                return;
            }

            else if (!HondCheckboxAdmin.Checked && !KatCheckboxAdmin.Checked && !ReptielCheckboxAdmin.Checked && !AmfibieCheckboxAdmin.Checked && !VissenCheckboxAdmin.Checked && InsectCheckboxAdmin.Checked && !KnaagdierCheckboxAdmin.Checked && !VogelCheckboxAdmin.Checked)
            {
                MessageBox.Show("Geef aan met welke dieren de gebruiker ervaring heeft");
            }
            else if (!OppassenAdmin.Checked && !UitlatenAdmin.Checked)
            {
                MessageBox.Show("Geef aan of de gebruiker op wil passen, uit wil laten of geïntresseerd is in beide");
            }
            else if (VoornaamAdmin.Text == "")
            {
                MessageBox.Show("Je hebt 1 of meerdere velden leeggelaten!");
            }
            else if (AchternaamAdmin.Text == "")
            {
                MessageBox.Show("Je hebt 1 of meerdere velden leeggelaten!");
            }
            else if (WoonplaatsAdmin.Text == "")
            {
                MessageBox.Show("Je hebt 1 of meerdere velden leeggelaten!");
            }
            else if (VraagprijsAdmin.Text == "" && double.TryParse(VraagprijsAdmin.Text, out var n))
            {
                MessageBox.Show("Je hebt 1 of meerdere velden leeggelaten!");
            }

            else
            {

                int currentr = (int)CurrentRow;
                int userid = (int)AdminDatagrid[0, currentr].Value;
                Gebruiker gebruiker = DatabaseManager.GebruikerOpvragen(userid);
                gebruiker.voornaam = VoornaamAdmin.Text;
                gebruiker.achternaam = AchternaamAdmin.Text;
                gebruiker.woonplaats = WoonplaatsAdmin.Text;
                gebruiker.vraagprijs = Convert.ToInt32(VraagprijsAdmin.Text);
                gebruiker.rating = Convert.ToInt32(RatingAdmin.Text);
                gebruiker.oppassen = OppassenAdmin.Checked;
                gebruiker.uitlaten = UitlatenAdmin.Checked;
                gebruiker.admin = AdminAdmin.Checked;
                gebruiker.verified = VerifiedAdmin.Checked;

                List<string> dierenstrings = new List<string>();
                if (HondCheckboxAdmin.Checked) dierenstrings.Add("Hond");
                if (KatCheckboxAdmin.Checked) dierenstrings.Add("Kat");
                if (KnaagdierCheckboxAdmin.Checked) dierenstrings.Add("Knaagdier");
                if (VogelCheckboxAdmin.Checked) dierenstrings.Add("Vogel");
                if (ReptielCheckboxAdmin.Checked) dierenstrings.Add("Reptiel");
                if (AmfibieCheckboxAdmin.Checked) dierenstrings.Add("Amfibie");
                if (InsectCheckboxAdmin.Checked) dierenstrings.Add("Insect");
                if (VissenCheckboxAdmin.Checked) dierenstrings.Add("Vissen");
                string dieren = string.Join(", ", dierenstrings);
                gebruiker.diertypes = dieren;

                DatabaseManager.GebruikerWijzigen(gebruiker);
                Refresh();
                MessageBox.Show("Het profiel is bijgewerkt");
            }
        }

        private void VerwijderButton_Click(object sender, EventArgs e)
        {
            //Als de gebruiker geen rij selecteerd, ga dan zeuren
            if (CurrentRow == null)
            {
                MessageBox.Show("Je hebt geen row geselecteerd");
                return;
            }

            DialogResult ResultaatVerwijderen = MessageBox.Show("Weet je zeker dat je het geselecteerde profiel wilt verwijderen?", "Verwijderen Profiel", MessageBoxButtons.YesNo);
            if (ResultaatVerwijderen == DialogResult.Yes)
            {
                int userid = (int)AdminDatagrid[0, (int)CurrentRow].Value;
                DatabaseManager.GebruikerVerwijderen(userid);
                Refresh();
            }
        }

        public void Refresh()
        {
            table.Clear();
            foreach (DataRow row in GetDataTable().Rows)
            {
                table.Rows.Add(row.ItemArray);
            }
        }
    }
}

