using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySql_Data_Input_Test
{
    public partial class Form1 : Form
    {
        public TcpLongServer Server;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Server = new TcpLongServer(textBox4.Text, int.Parse(textBox5.Text), (int)numericUpDown1.Value, (int)numericUpDown1.Value);
                Server.Start();
                richTextBox2.AppendText("[Server Starter] 服务器已启动");
            }
            catch(Exception ex)
            {
                richTextBox2.AppendText("[Server Starter] " + ex.Message + "\n");
            }
        }
    }
}
