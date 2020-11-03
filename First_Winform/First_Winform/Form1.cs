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
using System.IO;

namespace First_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://192.168.0.42:8080/on");

            Console.WriteLine(reply);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://192.168.0.42:8080/off");

            Console.WriteLine(reply);
        }
    }
}