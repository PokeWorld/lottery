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
    public partial class launcher : Form
    {
        public launcher()
        {
            InitializeComponent();
        }

        private void btnUltraBillions_MouseHover(object sender, EventArgs e)
        {
            lblAppTitleDisplay.Text = "Ultra Billions";
            lblAppDesc.Text = "Ultra Billions is an application where you would play the lottery\nin hopes of earning more money.";
        }

        private void btnUltraBillions_Click(object sender, EventArgs e)
        {
            new ultrabillions().Show();
        }

        private void launcher_MouseHover(object sender, EventArgs e)
        {
            lblAppTitleDisplay.Text = "";
            lblAppDesc.Text = "";
        }
    }
}
