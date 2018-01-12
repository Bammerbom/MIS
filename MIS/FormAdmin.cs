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
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            AdminDatagrid.DataSource = GetDataTable();
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
            AdminDatagrid.Columns[10].Width = 50 ;

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Verwijder Profiel";
            deleteButton.Text = "Verwijder";
            deleteButton.UseColumnTextForButtonValue = true;
            AdminDatagrid.Columns.Add(deleteButton);
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

        private void AdminDatagrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == AdminDatagrid.Columns["dataGridViewDeleteButton"].Index)
            {
                DialogResult ResultaatVerwijderen = MessageBox.Show("Weet je zeker dat je het geselecteerde profiel wilt verwijderen?", "Verwijderen Profiel", MessageBoxButtons.YesNo);
                if (ResultaatVerwijderen == DialogResult.Yes)
                {
                    int userid = (int) AdminDatagrid[0, e.RowIndex].Value;
                    DatabaseManager.GebruikerVerwijderen(userid);
                    AdminDatagrid.DataSource = GetDataTable();
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AdminDatagrid.ReadOnly = false;
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            AdminDatagrid.ReadOnly = true;
        }
    }
}
