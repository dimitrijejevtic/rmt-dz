using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterGUI
{
    public partial class Form2 : Form
    {
        public static string userName;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userName = textBox1.Text;
            Form1 frm1 = new Form1();          
            frm1.Show();
            this.Hide();
        }
    }
}
