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

        private void ZoekButton_Click(object sender, EventArgs e)
        {
            Valid = CheckValid(Valid);
            MessageBox.Show(Convert.ToString(Valid));
        }

        private bool CheckValid(bool X)
        {
            if (ZoektextBox != null)
            {
                int CheckedCount = 0;
                List<CheckBox> CBList = new List<CheckBox>()
                    { HondKatCheckBox, KnaagdierCheckBox, VogelCheckBox, ReptielAmfibieCheckBox, InsectCheckBox, AndersCheckBox};

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

        }

        
    }
}
