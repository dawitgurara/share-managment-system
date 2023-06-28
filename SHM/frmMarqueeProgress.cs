using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHM
{
    public partial class frmMarqueeProgress : Form
    {
        private System.Timers.Timer _frmTimer = new System.Timers.Timer();

        public string DescriptionLabel
        {
            set { this.label1.Text = value; }
        }
        public frmMarqueeProgress(int TimerTimeinMinue)
        {
            InitializeComponent();
            _frmTimer.Interval = TimerTimeinMinue * 60000;
            _frmTimer.Elapsed += new System.Timers.ElapsedEventHandler(frmTimer_Elapsed);
            _frmTimer.Start();
            // this.timer1.Interval = TimerTimeinMinue * 60000;
        }


        void frmTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            clMain.FinishedLoadFile = true;
            
        }
        public frmMarqueeProgress()
        {

            InitializeComponent();
        }

        private void frmMarqueeProgress_Load(object sender, EventArgs e)
        {
            System.Threading.Thread closeThread = new System.Threading.Thread(new System.Threading.ThreadStart(CloseMarqueForm));
            closeThread.Start();
        }

        private void CloseMarqueForm()
        {
            while (!clMain.FinishedLoadFile)
            {
                continue;
            }
            this.Close();
        }

       
    }
}
