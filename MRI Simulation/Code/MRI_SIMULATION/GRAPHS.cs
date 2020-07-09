using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRI_SIMULATION
{
    public partial class GRAPHS : Form
    {
        public GRAPHS()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MRIGRAPHS MR = new MRIGRAPHS();
            MR.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Blood_Volume BV = new Blood_Volume();
            BV.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Blood_Flow BF = new Blood_Flow();
            BF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mean_Transit_Time MTT = new Mean_Transit_Time();
            MTT.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Time_to_peak TTP = new Time_to_peak();
            TTP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allcharts AC = new allcharts();
            AC.Show();
        }
    }
}
