using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System;

namespace MRI_SIMULATION
{
    public partial class Mean_Transit_Time : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataSet ds;
        int rno = 0;
        public Mean_Transit_Time()
        {
            InitializeComponent();
        }

        private void Mean_Transit_Time_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@" provider=microsoft.jet.oledb.4.0; data source=C:\MRI_SIMULATION\MRI.mdb");

            cmd = new OleDbCommand("Select * from MRIRECORDS", con);

            OleDbDataReader mydatareader;



            con.Open();

            mydatareader = cmd.ExecuteReader();

            while (mydatareader.Read())
            {

                this.chart1.Series["MEAN_TRANSIT_TIME"].Points.AddXY(mydatareader.GetString(6), mydatareader.GetString(4));
            }
        }
    }
}
