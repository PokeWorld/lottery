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
    public partial class ultrabillions : Form
    {
        public ultrabillions()
        {
            InitializeComponent();
        }

        private void btnGenNewPlayerNumber_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int digit1 = r.Next(10);
            int digit2 = r.Next(10);
            int digit3 = r.Next(10);
            int digit4 = r.Next(10);
            int digit5 = r.Next(10);

            lblYourNumbers.Text = "Your Numbers: " + digit1 + " " + digit2 + " " + digit3 + " " + digit4 + " " + digit5;

            Random r2 = new Random();

            Random r3 = new Random();

            int digit6 = r2.Next(10);
            int digit7 = r3.Next(10);
            int digit8 = r2.Next(10);
            int digit9 = r3.Next(10);
            int digit10 = r2.Next(10);

            lblWinningNumbers.Text = "Winning Numbers: " + digit6 + " " + digit7 + " " + digit8 + " " + digit9 + " " + digit10;

        }
    }
}
