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
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataSet ds;
        int rno = 0;
        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection(@" provider=microsoft.jet.oledb.4.0; data source=C:\MRI_SIMULATION\MRI.mdb");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            con = new OleDbConnection(@" provider=microsoft.jet.oledb.4.0; data source=C:\MRI_SIMULATION\MRI.mdb");
            con.Open();
            cmd = new OleDbCommand("select * from MRIRECORDS ", con);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "CHANGE";
            btn.Text = "change";
            btn.Name = "change";
            btn.UseColumnTextForButtonValue = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                con = new OleDbConnection(@" provider=microsoft.jet.oledb.4.0; data source=C:\MRI_SIMULATION\MRI.mdb");
                cmd = new OleDbCommand("insert into MRIRECORDS(MRI,Blood_Volume,Blood_Flow,Mean_Transit_Time,Time_to_peak,PATIENTNAME) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    MessageBox.Show("MRI record inserted");
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = null;

                    con = new OleDbConnection(@" provider=microsoft.jet.oledb.4.0; data source=C:\MRI_SIMULATION\MRI.mdb");
                    con.Open();
                    cmd = new OleDbCommand("select * from MRIRECORDS ", con);
                    cmd.CommandType = CommandType.Text;
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    dataGridView1.Columns.Add(btn);
                    btn.HeaderText = "CHANGE";
                    btn.Text = "change";
                    btn.Name = "change";
                    btn.UseColumnTextForButtonValue = true;
                }
                else
                    MessageBox.Show("insertion MRI records failed");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.blood_volume();
            this.blood_flow();
            this.mean_transit_time();
            this.time_to_peak();

        }
        public void blood_volume()
        {
            if (textBox1.Text != "")
            {
                textBox2.Text = Convert.ToDouble(Convert.ToInt32(textBox1.Text) * 0.2).ToString();
                MessageBox.Show("The blood volume is\t" + textBox2.Text);

            }
        }
        public void blood_flow()
        {
            if (textBox1.Text != "")
            {
                textBox3.Text = Convert.ToDouble(Convert.ToInt32(textBox1.Text) * 0.3).ToString();
                MessageBox.Show("The blood flow is\t" + textBox3.Text);
            }
        }
        public void mean_transit_time()
        {
            if (textBox1.Text != "")
            {
                textBox4.Text = Convert.ToDouble(Convert.ToInt32(textBox1.Text) * 0.4).ToString();
                MessageBox.Show("The mean transit time is\t" + textBox4.Text);
            }
        }
        public void time_to_peak()
        {
            if (textBox1.Text != "")
            {
                textBox5.Text = Convert.ToDouble(Convert.ToInt32(textBox1.Text) * 0.5).ToString();
                MessageBox.Show("The time to peak is\t" + textBox5.Text);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                //dataGridView1.Rows[e.RowIndex];
                //MessageBox.Show((dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");

                //patientstests pts = new patientstests();
                //REGISTERPATIENTS sp = new REGISTERPATIENTS();
                //this.Hide();
                //pts.label16.Text = label16.Text.ToString();
                //pts.label17.Text = label17.Text.ToString();
                this.label8.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                //label9.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //f2.label8.Text = textBox3.Text.ToString();
                //pts.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            { 
                //MRIID,MRI,Blood_Volume,Blood_Flow,Mean_Transit_Time,Time_to_peak,PATIENTNAME
                con = new OleDbConnection(@" provider=microsoft.jet.oledb.4.0; data source=C:\MRI_SIMULATION\MRI.mdb");
                //cmd = new OleDbCommand("update MRIRECORDS set MRI=@MRI,Blood_Volume=@Blood_Volume,Blood_Flow=@Blood_Flow,Mean_Transit_Time=@Mean_Transit_Time,Time_to_peak=@Time_to_peak,PATIENTNAME=@PATIENTNAME where MRIID="+Convert.ToInt32(label8.Text)+"", con);
                cmd = new OleDbCommand("update MRIRECORDS set MRI=@MRI,Blood_Volume=@Blood_Volume,Blood_Flow=@Blood_Flow,Mean_Transit_Time=@Mean_Transit_Time,Time_to_peak=@Time_to_peak,PATIENTNAME=@PATIENTNAME where MRIID=" + Convert.ToInt32(label8.Text) + "", con);
                con.Open();
                //int MRIID = Convert.ToInt32(label8.Text);
                cmd.Parameters.AddWithValue("@MRI", textBox1.Text);
                cmd.Parameters.AddWithValue("@Blood_Volume", textBox2.Text);
                cmd.Parameters.AddWithValue("@Blood_Flow", textBox3.Text);
                cmd.Parameters.AddWithValue("@Mean_Transit_Time", textBox4.Text);
                cmd.Parameters.AddWithValue("@Time_to_peak", textBox5.Text);
                cmd.Parameters.AddWithValue("@PATIENTNAME", textBox6.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("MRI Record Updated Successfully" + label8.Text);
                //dataGridView1
                //dataGridView1.DataSource = "";  
            }
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null; 
            con = new OleDbConnection(@" provider=microsoft.jet.oledb.4.0; data source=C:\MRI_SIMULATION\MRI.mdb");
            con.Open();
            cmd = new OleDbCommand("select * from MRIRECORDS ", con);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "CHANGE";
            btn.Text = "change";
            btn.Name = "change";
            btn.UseColumnTextForButtonValue = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GRAPHS GRPS = new GRAPHS();
            GRPS.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MRI Record Updated Successfully" + textBox5.Text);
        }
    }
}
