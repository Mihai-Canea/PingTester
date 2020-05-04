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

namespace PingTester.myForms
{
    public partial class ReconTools : DockContent
    {
        DockPanel dockPanel;
        public ReconTools(DockPanel dock)
        {
            InitializeComponent();
            dockPanel = dock;
        }

        private void ReconTools_Load(object sender, EventArgs e)
        {

        }

        private void btnSubfinder_Click(object sender, EventArgs e)
        {
            myForms.ToolTesting sub = new ToolTesting();
            sub.ToolName = "subfinder";
            sub.CommandTool = $"/c subfinder -d {txtDomain.Text}";
            sub.Show(dockPanel, DockState.Document);
        }

        private void btnAmass_Click(object sender, EventArgs e)
        {
            myForms.ToolTesting am = new myForms.ToolTesting();
            am.ToolName = "amass";
            // amass enum -v -brute -min-for-recursive 2 -d tesla.com
            // amass enum --passive -d example.com
            am.CommandTool = $"/c amass enum --passive -d {txtDomain.Text}";
            am.Show(dockPanel,DockState.Document);
        }
    }
}
