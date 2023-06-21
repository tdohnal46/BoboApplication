using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;


using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;


namespace Updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WebClient web = new WebClient();
            var client = new WebClient();

            try
            {
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\bobo_1.exe");
                client.DownloadFile("http://bobostorage.000webhostapp.com/update/bobo_1.zip", @"bobo_1.zip");
                string ZipPath = @".\bobo_1.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(ZipPath, extractPath);
                File.Delete(@".\bobo_1.zip");
                Process.Start(@".\bobo_1.exe");

            }
            catch
            {
                Process.Start("bobo_1.exe");
                this.Close();
               
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
