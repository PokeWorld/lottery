using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revolution_demos
{
    public partial class qwick_antiwirus : Form
    {
        private int wiruses = 0;

        public qwick_antiwirus()
        {
            InitializeComponent();
        }

        private void btnRunScan_Click(object sender, EventArgs e)
        {
            if(tmrUpdate.Enabled == false)
            {
                tmrUpdate.Enabled = true;
            }
            else
            {
                tmrUpdate.Enabled = false;
            }
            
        }
        
        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            wiruses += 1;

            lblwiruses.Text = wiruses + " Wiruses Found So Far";
            
        }
    }
}
