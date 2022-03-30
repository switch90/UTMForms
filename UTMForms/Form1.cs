using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using CefSharp;
using System.Text.RegularExpressions;

namespace UTMForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Chromium.FrameLoadEnd += WebBrowserFrameLoadEnded;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Ip = textBox1.Text;
            ServiceController sc = new ServiceController("Transport", Ip);
            textBox2.Text = Convert.ToString(sc.Status);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            string Ip = textBox1.Text;
            Ping myPing = new Ping();
            PingReply reply = myPing.Send(Ip, 2000);

            if (reply.Status == IPStatus.TimedOut)
            {
                textBox2.Text = "Данный пк не в сети";
                button7.Enabled = true;

            }
            else if (reply.Status == IPStatus.Success)
            {
                checkedListBox1.SetItemChecked(0, true);
                button2.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                checkedListBox1.Enabled = true;

                ServiceController sc = new ServiceController("Transport", Ip);
                try
                {
                    textBox2.Text = Convert.ToString(sc.Status);
                    if (Convert.ToString(sc.Status) == "Running")
                    {
                        checkedListBox1.SetItemChecked(2, true);
                    }
                }
                catch (Exception)
                {
                    textBox2.Text = "Данная служба не найдена или не удается получить её статус";
                    textBox1.Enabled = true;
                    button2.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button8.Enabled = false;
                    checkedListBox1.Enabled = false;
                    checkedListBox1.SetItemChecked(0, false);
                    checkedListBox1.SetItemChecked(1, false);
                    checkedListBox1.SetItemChecked(2, false);
                    progressBar1.Enabled = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Chromium.LoadUrl(textBox1.Text + ":8080/app/");
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Chromium.LoadUrl("0");
            textBox1.Enabled = true;
            textBox1.Text = null;
            textBox2.Text = null;
            button2.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            checkedListBox1.Enabled = false;
            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(2, false);
            progressBar1.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string Ip = textBox1.Text;
            ServiceController sc = new ServiceController("Transport", Ip);
            if ((sc.Status.Equals(ServiceControllerStatus.Stopped)) || (sc.Status.Equals(ServiceControllerStatus.StopPending)))
            {
                sc.Start();
            }
            else
            {
                sc.Stop();
                progressBar1_Click(sender, e);
            }
            sc.Refresh();
            textBox2.Text = Convert.ToString(sc.Status);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Ip = textBox1.Text;
            ServiceController sc = new ServiceController("Transport", Ip);
            sc.Stop();
            textBox2.Text = "Служба ОСТАНАВЛИВАЕТСЯ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Ip = textBox1.Text;
            ServiceController sc = new ServiceController("Transport", Ip);
            sc.Start();
            textBox2.Text = "Служба ЗАПУСКАЕТСЯ";
        }

        public void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Enabled = true;
            progressBar1.Maximum = 100;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value++;
                Thread.Sleep(900);
                if (progressBar1.Value == 100)
                {
                    string Ip = textBox1.Text;
                    ServiceController sc = new ServiceController("Transport", Ip);
                    sc.Start();
                    progressBar1.Value = 0;
                    progressBar1.Enabled = false;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.GetItemText(listBox1.SelectedItem);
            MatchCollection addr = new Regex(@"192\.168\.\d{1,3}\.\d{1,3}").Matches(str);
            foreach (var ip in addr)
                textBox1.Text = Convert.ToString(ip);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string URLtoCheck = null;
            for (int i = 1; i < listBox1.Items.Count; i++)
            {
                string str = listBox1.GetItemText(listBox1.Items[i]);
                MatchCollection addr = new Regex(@"192\.168\.\d{1,3}\.\d{1,3}").Matches(str);
                foreach (var ip in addr)
                {
                    URLtoCheck = Convert.ToString(ip);
                    Chromium.LoadUrl(URLtoCheck + ":8080/app/");
                    Thread.Sleep(6000);

                }    
            }
        }

        private void WebBrowserFrameLoadEnded(object sender, FrameLoadEndEventArgs e)
        {
            if (e.HttpStatusCode.ToString() == "0")
            {
                MessageBox.Show("Ошибка загрузки страницы утм \nЛибо происходит сброс станицы из-за нажатия кнопки");
            }            
        }
    }
}
