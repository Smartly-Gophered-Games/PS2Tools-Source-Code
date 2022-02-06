using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS2Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                Process[] processes = Process.GetProcessesByName("ProjectSpeed2");
                if (processes.Length == 0)
                {

                    string message = "Project Speed 2 Executable is not running.";
                    string title = "Executable Verification";
                    MessageBox.Show(message, title);

                }
                else
                {

                    string message = "Project Speed 2 Executable is running.";
                    string title = "Executable Verification";
                    MessageBox.Show(message, title);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("ProjectSpeed2"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}