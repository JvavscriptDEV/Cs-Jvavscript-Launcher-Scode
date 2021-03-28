using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace JvavScriptLauncher
{
    public partial class Form1 : Form
    {
        private const string G = "ForestGreen";
        private const string R = "DarkRed";
        string a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("http://www.jvavexec.top/");
            p.WaitForExit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process p = Process.Start(".\\JvavScript.exe");
            p.WaitForExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process p = Process.Start(".\\jvavwebs.exe");
            p.WaitForExit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process p = Process.Start(".\\login.exe");
            p.WaitForExit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("http://www.jvavexec.top/404.html");
            p.WaitForExit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "程序运行中......";
            this.a = comboBox1.SelectedIndex.ToString() + " " + comboBox1.Text;
            Process p = Process.Start(".\\JvavScript.exe", a);
            p.WaitForExit();
            button6.Text = "启动";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process p = Process.Start(".\\help.txt");
            p.WaitForExit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("https://github.com/JvavscriptDEV");
            p.WaitForExit();
        }

        private void eventLog1_EntryWritten(object sender, EntryWrittenEventArgs e)
        {

        }
    }
}
