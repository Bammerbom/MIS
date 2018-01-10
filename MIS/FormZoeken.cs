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
    public partial class FormZoeken : Form
    {
        bool Valid;
        public FormZoeken()
        {
            InitializeComponent();
        }

        //Click event
        private void ZoekButton_Click(object sender, EventArgs e)
        {
            Valid = CheckValid();
            if (Valid == true)
            {
                MessageBox.Show(Convert.ToString(Valid));
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        /// <summary>
        /// Zorgt ervoor dat je maar 1 huisdiercheckbox kan checken
        /// </summary>
        private void Huisdierbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                List<CheckBox> CBList = new List<CheckBox>()
                    { HondCheckBox, KatCheckBox, KnaagdierCheckBox, VogelCheckBox, ReptielCheckBox, AmfibieCheckBox, InsectCheckBox, VisCheckBox};

                foreach (var Checkbox in CBList)
                {
                    if (Checkbox != box)
                    {
                        Checkbox.Checked = false;
                    }
                }
            }
        }

        /// <summary>
        /// zorgt ervoor dat oppas en uitlaat te gelijk gechecked zijn
        /// </summary>
        private void Extra_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                List<CheckBox> CBList = new List<CheckBox>()
                    {OppasCheckBox, UitlaatCheckBox};

                foreach (var Checkbox in CBList)
                {
                    if (Checkbox != box)
                    {
                        Checkbox.Checked = false;
                    }
                }
            }
        }

        /// <summary>
        /// Zorgt dat er geldige parameters zijn gegeven.
        /// </summary>
        /// <returns>of het een geldige zoek functie is</returns>
        private bool CheckValid()
        {
            if (ZoektextBox.Text != "")
            {
                int CheckedCount = 0;
                List<CheckBox> CBList = new List<CheckBox>()
                    { HondCheckBox, KatCheckBox, KnaagdierCheckBox, VogelCheckBox, ReptielCheckBox, AmfibieCheckBox, InsectCheckBox, VisCheckBox};

                foreach (var y in CBList)
                {
                    if (y.Checked)
                    {
                        CheckedCount++;
                    }
                }

                if (CheckedCount == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void Buildquery()
        {
            DatabaseManager.AlleGebruikers();











        }  
    }
}
