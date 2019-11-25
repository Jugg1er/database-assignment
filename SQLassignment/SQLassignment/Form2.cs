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
    public partial class Form2 : Form
    {
        //MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=123456;database=test;");
        public Form2()
        {
            InitializeComponent();
            //Globals.conn.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int sensorID;
            sensorID = int.Parse(textBox1.Text);
            int batchNo;
            batchNo = int.Parse(textBox2.Text);
            string productDate;
            productDate = textBox3.Text + "-" + textBox5.Text + "-" + textBox6.Text;
            float freq;
            freq = int.Parse(textBox4.Text);
            */
            string cmdText="insert into sensor values('"+textBox1.Text+"','"+textBox2.Text+"','"+ textBox3.Text + "-" + textBox5.Text + "-" + textBox6.Text+"',"+textBox4.Text+")";
            MySqlCommand cmd = new MySqlCommand(cmdText, Globals.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("录入传感器信息成功！");
        }
    }
}
