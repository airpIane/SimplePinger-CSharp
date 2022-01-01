using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(host.Text)) return;
            string PingCMD = $"/K mode con lines=25 cols=60 & ping {host.Text} -t";
            Process.Start("CMD.exe", PingCMD);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] proc = Process.GetProcessesByName("paping");
            new Process
            {
                StartInfo =
                {
                    UseShellExecute = false,
                    FileName = "paping.exe",
                    Arguments = host.Text + " -p " + port.Text
                }
            }.Start();

        }

        }
    }
