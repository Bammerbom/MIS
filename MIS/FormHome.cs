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
    public partial class FormHome : Form
    {
        public static FormHome Home;
        public static ControlZoekenHeader CZH = new ControlZoekenHeader();
        public static ControlZoekenBody CZB = new ControlZoekenBody();
        public FormHome()
        {
            InitializeComponent();
            Home = this;
            panelH.Controls.Add(CZH);
            panelB.Controls.Add(CZB);
        }
    }
}
