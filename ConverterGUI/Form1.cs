using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ConverterGUI
{
    public partial class Form1 : Form
    {
        string message=null;
        List<Button> buttons = new List<Button>();
        public Form1()
        {       
            
            InitializeComponent();          
            buttons.Add(button1); buttons.Add(button2); buttons.Add(button3); buttons.Add(button4);
            buttons.Add(button5); buttons.Add(button9); buttons.Add(button6); buttons.Add(button13);
            buttons.Add(button10); buttons.Add(button7); buttons.Add(button14); buttons.Add(button11);
            buttons.Add(button8); buttons.Add(button12); buttons.Add(button15); buttons.Add(button16);
            connect();
        }

        public void connect()
        {
            Int32 port = 10000;
            TcpClient client = new TcpClient("localhost", port);
            //generate standard message for server (username, services, port, ip)
            message ="REG"+Form2.userName +","+getIpAdress()+ "," + "12345678,"+"10001"+ Environment.NewLine;
            textBox2.Text =Form2.userName;
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
            data = new Byte[256];
            String responce = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responce = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            textBox2.Text =textBox2.Text + " "+ responce;
            stream.Close();
            client.Close();

        }

        private string getIpAdress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }
        #region events
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "c";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "a";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "b";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "d";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "e";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "f";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons.ElementAt(i).Enabled = true;
                }
            }else
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons.ElementAt(i).Enabled =false ;
                    textBox1.Clear();
                }
            button17.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                for (int i = 0; i < buttons.Count-6; i++)
                {
                    buttons.ElementAt(i).Enabled = true;
                }
            }
            else
                for (int i = 0; i < buttons.Count-6; i++)
                {
                    buttons.ElementAt(i).Enabled = false;
                    textBox1.Clear();
                }
            button17.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                for (int i = 0; i < buttons.Count - 8; i++)
                {
                    buttons.ElementAt(i).Enabled = true;
                }
            }
            else
                for (int i = 0; i < buttons.Count - 8; i++)
                {
                    buttons.ElementAt(i).Enabled = false;
                    textBox1.Clear();
                }
            button17.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                for (int i = 0; i < buttons.Count - 12; i++)
                {
                    buttons.ElementAt(i).Enabled = true;
                }
            }
            else
                for (int i = 0; i < buttons.Count - 12; i++)
                {
                    buttons.ElementAt(i).Enabled = false;
                    textBox1.Clear();
                }
            button17.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                for (int i = 0; i < buttons.Count - 14; i++)
                {
                    buttons.ElementAt(i).Enabled = true;
                }
            }
            else
                for (int i = 0; i < buttons.Count - 14; i++)
                {
                    buttons.ElementAt(i).Enabled = false;
                    textBox1.Clear();
                }
            button17.Enabled = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                for (int i = 0; i < buttons.Count - 6; i++)
                {
                    buttons.ElementAt(i).Enabled = true;
                }
            }
            else
                for (int i = 0; i < buttons.Count - 6; i++)
                {
                    buttons.ElementAt(i).Enabled = false;
                    textBox1.Clear();
                }
            button17.Enabled = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                for (int i = 0; i < buttons.Count - 11; i++)
                {
                    buttons.ElementAt(i).Enabled = true;
                }
            }
            else
                for (int i = 0; i < buttons.Count - 11; i++)
                {
                    buttons.ElementAt(i).Enabled = false;
                    textBox1.Clear();
                }
            button17.Enabled = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                for (int i = 0; i < buttons.Count - 9; i++)
                {
                    buttons.ElementAt(i).Enabled = true;
                }
            }
            else
                for (int i = 0; i < buttons.Count - 9; i++)
                {
                    buttons.ElementAt(i).Enabled = false;
                    textBox1.Clear();
                }
            button17.Enabled = true;
        }
        #endregion events

        private void button17_Click(object sender, EventArgs e)
        {
            //send GET request and handle the responce and new connection to the other client
            Int32 port = 10000;
            TcpClient client = new TcpClient("localhost", port);
            message = "GET"+","+ serviceSelected();
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
            data = new Byte[256];
            String responce = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responce = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            string[] listData = responce.Split(':');
            string[] names = null;
            int i = 0;
            foreach(string str in listData)
            {
                string[] temp=str.Split(',');
                names[i] = temp[0];
                i++;
            }
            listBox1.Items.AddRange(names); 

        }
        public int serviceSelected()
        {
            if (radioButton1.Enabled)
            {
                return 1;
            }
            if (radioButton2.Enabled)
            {
                return 2;
            }
            if (radioButton3.Enabled)
            {
                return 3;
            }
            if (radioButton4.Enabled)
            {
                return 4;
            }
            if (radioButton5.Enabled)
            {
                return 5;
            }
            if (radioButton6.Enabled)
            {
                return 6;
            }
            if (radioButton7.Enabled)
            {
                return 7;
            }
            return 8;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //new connection to selected user
        }

    }
}
