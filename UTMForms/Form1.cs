﻿using System;
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

namespace UTMForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Ip = textBox1.Text;
            ServiceController sc = new ServiceController("Transport", Ip);
            sc.ServiceName = "Transport";
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
            else if(reply.Status == IPStatus.Success)
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
                }
                catch (Exception)
                {
                    textBox2.Text = "Данная служба не найдена или не удается получить её статус";
                }
                if(Convert.ToString(sc.Status) == "Running")
                {
                    checkedListBox1.SetItemChecked(2, true);
                }
            }           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Chromium.LoadUrl(textBox1.Text+ ":8080/app/");
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
            progressBar1.Maximum = 100;
            for(int i = 0; i < 100; i++)
            {
                progressBar1.Value++;
                Thread.Sleep(1100);
            }
            if(progressBar1.Value == 100)
            {
                string Ip = textBox1.Text;
                ServiceController sc = new ServiceController("Transport", Ip);
                sc.Start();
            }
        }
    }
}
