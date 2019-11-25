using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQLassignment
{

    public partial class Form1 : Form
    {
        //MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;User Id=root;password=123456;database=test;");
        public Form1()
        {
            InitializeComponent();
            
            //Globals.conn.Open();
        }

        private void 录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 传感器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
           
        }

        private void 阅读器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void 配置工程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void 故障率ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void 传感器个数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("Select Count(*) From sensor", Globals.conn);
            MessageBox.Show("传感器个数为："+cmd.ExecuteScalar().ToString());
        }

        private void 配置了12个频点的全部阅读器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("Select ReaderID,Frequency From sensor,(Select ReaderID,SensorID From readersensor Group By ReaderID Having count(*)=12) AS temp Where sensor.SensorID=temp.SensorID Order By ReaderID", Globals.conn);
            MySqlDataReader rd = cmd.ExecuteReader();
            string str = "";
            int i = 0;
            while(rd.Read())
            {
                if(i==0)
                {
                    str = str + "ReaderID:" + rd["ReaderID"] + "  对应频点：" + "\n";
                }
                str = str + rd["Frequency"] + "\t";
                i += 1;
                i = i % 12;
                if (i == 0)
                    str = str + "\n";
            }
            MessageBox.Show(str);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.conn = new MySqlConnection("server=localhost;port=3306;User Id=" + textBox1.Text + ";password=" + textBox2.Text + ";database=" + textBox3.Text + ";");
            try
            {
                Globals.conn.Open();
                MessageBox.Show("连接成功！");
            }
            catch(MySqlException err)
            {
                MessageBox.Show("连接失败");
            }
        }
    }
    public static class Globals
    {
        public static MySqlConnection conn;
    }
}
