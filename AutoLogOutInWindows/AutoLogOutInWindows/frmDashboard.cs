using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLogOutInWindows
{
    public partial class frmDashboard : Form
    {
        Timer timer = new Timer();
        DateTime dtTimer = DateTime.Now;
        DateTime dtRefresh = DateTime.Now;
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dtTimer = dtTimer.AddSeconds(1);
        }

        private void frmDashboard_MouseHover(object sender, EventArgs e)
        {
            //If Time difference more than 5 minutes then automatic logout
            TimeSpan TimeDifference = dtTimer.Subtract(dtRefresh);
            if (TimeDifference.Minutes > 5)
            {
                AdminLogin obj = new AdminLogin();
                obj.Show();
                this.Hide();
            }
            else
            {
                dtRefresh = dtTimer;
            }
        }
    }
}
