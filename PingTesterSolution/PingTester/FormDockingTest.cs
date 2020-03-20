using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PingTester
{
    public partial class FormDockingTest : Form
    {
        public FormDockingTest()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            Form2 f2 = new Form2();
            f2.Show(dockPanel1, DockState.DockLeft);
        }
    }
}
