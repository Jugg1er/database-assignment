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
    public partial class Form3 : Form
    {
        //MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=123456;database=test;");
        public Form3()
        {
            InitializeComponent();
            //Globals.conn.Open();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdText = "insert into reader values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "-" + textBox4.Text + "-" + textBox5.Text + "')";
            MySqlCommand cmd = new MySqlCommand(cmdText, Globals.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("录入阅读器信息成功！");
        }
    }
}
