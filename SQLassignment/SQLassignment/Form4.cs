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
    public partial class Form4 : Form
    {
        //MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=123456;database=test;");
        public Form4()
        {
            InitializeComponent();
            //Globals.conn.Open();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1,cmd2,cmd3;
            if(radioButton1.Checked)
            {
                cmd1 = new MySqlCommand("UPDATE sensor SET SensorID='" + textBox2.Text + "',BatchNo='" + textBox3.Text + "',ProductDate='" + textBox4.Text + "-" + textBox5.Text + "-" + textBox6.Text + "' WHERE SensorID='" + textBox1.Text + "'", Globals.conn);
                cmd1.ExecuteNonQuery();
                cmd2 = new MySqlCommand("UPDATE readersensor SET SensorID='" + textBox2.Text + "' WHERE SensorID='" + textBox1.Text + "'", Globals.conn);
                cmd2.ExecuteNonQuery();
            }
            if(radioButton2.Checked)
            {
                cmd1 = new MySqlCommand("UPDATE reader SET ReaderID='" + textBox2.Text + "',BatchNo='" + textBox3.Text + "',ProductDate='" + textBox4.Text + "-" + textBox5.Text + "-" + textBox6.Text + "' WHERE ReaderID='" + textBox1.Text + "'", Globals.conn);
                cmd1.ExecuteNonQuery();
                cmd2 = new MySqlCommand("UPDATE readersensor SET ReaderID='" + textBox2.Text + "' WHERE ReaderID='" + textBox1.Text + "'", Globals.conn);
                cmd2.ExecuteNonQuery();
                cmd3 = new MySqlCommand("UPDATE projectreader set ReaderID='" + textBox2.Text + "' WHERE ReaderID='" + textBox1.Text + "'", Globals.conn);
                cmd3.ExecuteNonQuery();
            }
            MessageBox.Show("替换完成");
        }
    }
}
