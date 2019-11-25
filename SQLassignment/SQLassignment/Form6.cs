using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLassignment
{
    public partial class Form6 : Form
    {
        //MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=123456;database=test;");
        public Form6()
        {
            InitializeComponent();
            //Globals.conn.Open();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd1,cmd2;
            int all, wrg;
            if (radioButton1.Checked)
            {
                cmd1 = new MySqlCommand("SELECT COUNT(DISTINCT ReaderorSensorID) FROM maintenance WHERE ReaderorSensorID IN (SELECT SensorID FROM sensor)", Globals.conn);
                wrg = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                cmd2 = new MySqlCommand("SELECT COUNT(*) FROM sensor", Globals.conn);
                all = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                textBox1.Text = Convert.ToString(100*wrg/all)+"%";
            }
            if(radioButton2.Checked)
            {
                cmd1 = new MySqlCommand("SELECT COUNT(DISTINCT ReaderorSensorID) FROM maintenance WHERE ReaderorSensorID IN (SELECT ReaderID FROM reader)", Globals.conn);
                wrg = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                cmd2 = new MySqlCommand("SELECT COUNT(*) FROM reader", Globals.conn);
                all = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                textBox1.Text = Convert.ToString(100 * wrg / all) + "%";
            }
        }
    }
}
