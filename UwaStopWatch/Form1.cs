using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UwaStopWatch
{
    public partial class MainForm : Form
    {

        private static int seconds = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timerMain.Enabled)
            {
                timerMain.Stop();
                btnStart.Text = "&START";
            }
            else
            {
                timerMain.Start();
                btnStart.Text = "&STOP";
            }
            
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            seconds += 1;
            txtClock.Text = getTimeString(seconds);
        }

        private string getTimeString(int seconds)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((seconds / 60).ToString("D3"))
                .Append(":")
                .Append((seconds % 60).ToString("D2"));

            return sb.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timerMain.Stop();
            seconds = 0;
            txtClock.Text = getTimeString(seconds);
        }
    }
}
