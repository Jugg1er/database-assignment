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

    public partial class Form5 : Form
    {
        //MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=123456;database=test;");
        public Form5()
        {
            InitializeComponent();
            //Globals.conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strText = textBox1.Text.Split('\n');
            MySqlCommand cmd1 = new MySqlCommand("INSERT INTO project VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", Globals.conn);
            cmd1.ExecuteNonQuery();
            int i = 0;
            MySqlCommand cmd2 = new MySqlCommand("SELECT ReaderID FROM reader WHERE ReaderID NOT IN (select ReaderID from readersensor) LIMIT 1", Globals.conn);
            MySqlCommand cmd3,cmd4;
            string readerID="";

            foreach (string s in strText)
            {
                if (i % 12 == 0)
                {
                   readerID = cmd2.ExecuteScalar().ToString();
                }
                //float f = Convert.ToSingle(s);
                cmd3 = new MySqlCommand("select SensorID from sensor where Frequency=" + s + " limit 1", Globals.conn);
                string sensorID = cmd3.ExecuteScalar().ToString();
                cmd4 = new MySqlCommand("insert into readersensor values('" + readerID + "','" + sensorID + "')", Globals.conn);
                cmd4.ExecuteNonQuery();
                i = i + 1;
            }

            //打印配置信息


            this.Close();
        }
    }
}
