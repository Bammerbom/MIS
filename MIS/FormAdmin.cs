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
            AdminDatagrid.Columns[0].Width = 125;
            AdminDatagrid.Columns[1].Width = 125;
            AdminDatagrid.Columns[2].Width = 100;
            AdminDatagrid.Columns[3].Width = 50;
            AdminDatagrid.Columns[4].Width = 50;
            AdminDatagrid.Columns[5].Width = 71;
            AdminDatagrid.Columns[6].Width = 60;
            AdminDatagrid.Columns[7].Width = 60;
            AdminDatagrid.Columns[8].Width = 225;
            AdminDatagrid.Columns[9].Width = 50;
        }

        public DataTable GetDataTable()
        {
            //Maak een nieuwe tabel
            DataTable table = new DataTable();
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
                table.Rows.Add(gebruiker.voornaam, gebruiker.achternaam, gebruiker.woonplaats, gebruiker.verified, gebruiker.admin, gebruiker.vraagprijs, gebruiker.oppassen, gebruiker.uitlaten, gebruiker.diertypes, gebruiker.rating);
            }

            return table;
        }
    }
}
