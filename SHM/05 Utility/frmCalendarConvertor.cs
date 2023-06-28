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
    public partial class frmCalendarConvertor : Form
    {
        public frmCalendarConvertor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.EthioDateTextBox.Text = clUtility.GetEthDate(this.GregDateTimePicker.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.GregDateTimePicker.Value = clUtility.GetGrgDate(this.EthioDateTextBox.Text);
        }
    }
}
