using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace MRI_SIMULATION
{
    public partial class Blood_Volume : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataSet ds;
        int rno = 0;
        public Blood_Volume()
        {
            InitializeComponent();
        }

        private void Blood_Volume_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@" provider=microsoft.jet.oledb.4.0; data source=C:\MRI_SIMULATION\MRI.mdb");
            cmd = new OleDbCommand("Select * from MRIRECORDS", con);
            OleDbDataReader mydatareader;
            con.Open();
            mydatareader = cmd.ExecuteReader();
            while (mydatareader.Read())
            {
                this.chart1.Series["BLOOD_VOLUME"].Points.AddXY(mydatareader.GetString(6), mydatareader.GetString(2));
            }
        }
    }
}
