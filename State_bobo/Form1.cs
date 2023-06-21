
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;
using System.Web.UI.WebControls;
using System.Net;
using System.Diagnostics;
using Guna.UI2.WinForms;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.IO;
using System.Xml.Schema;

namespace State_bobo
{
    public partial class Cumunikator : Form
    {
        const int pocet = 5;
        int tecka=0;
        bool replying=false;
        bool connection = false;
        int opakovani=pocet;
        int hodina_start=9;
        int hodina_end=10;
        int minuta_start=0;
        int minuta_end=21;
        Alarm_mess alarm = new Alarm_mess();
        string path_txt = @"data.txt";
        bool open=false;
        Guna2HtmlLabel label = new Guna2HtmlLabel();

        public Cumunikator()
        {
            InitializeComponent();
            Check_timer.Start();
            timer.Start();
            timer.Interval = opakovani *1000;
           
;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader(path_txt);
            hod1.Text=read.ReadLine();
            hod2.Text=read.ReadLine();
            min1.Text=read.ReadLine();
            min2.Text=read.ReadLine();
            read.Close();
            string cesta = "AdressIPV4.txt";
            StreamReader sw = new StreamReader(cesta);
            IP_text.Text= sw.ReadLine();
            sw.Close();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            if (start_btn.Text.Contains("Zastavit"))
            {
                indikator.ProgressColor = Color.Yellow;
                indikator.Stop();

                timer.Stop();
                nacitani.Stop();
                IP_text.Enabled = true;
                start_btn.FillColor = Color.Green;
                start_btn.Text = "Start";

                konzole.Text += "\nPřipojování bylo přerušeno...";
            }
            else
            {
                konzole.ForeColor = Color.White;
                indikator.ProgressColor = Color.Yellow;
                indikator.Start();
                IP_text.Enabled = false;
                timer.Start();
                start_btn.FillColor = Color.Red;
                start_btn.Text = "Zastavit";
                konzole.Text += "\nPřipojování se opětovně spustilo...";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
            replying = true;
            string IP = IP_text.ToString();
            
            


            Ping ping = new Ping(); 
            
                PingReply odpoved = ping.Send(IP_text.Text);
            if(odpoved.Status.ToString() == "Success")
            {
                konzole.ForeColor = Color.White;
                konzole.Text = "Aplikace běží...";
                indikator.ProgressColor = Color.YellowGreen;
                opakovani = pocet;
                connection = true;
                nacitani.Start();
                start_btn.FillColor = Color.Red;
                start_btn.Text = "Zastavit";
            }
            else
            {
                konzole.ForeColor = Color.Red;
                konzole.Text += "\nAplikace neodpovídá!";
                timer.Stop();
                indikator.ProgressColor = Color.Red;
                indikator.Stop();
                connection = false;
                start_btn.FillColor = Color.Green;
                start_btn.Text = "Spustit";
                IP_text.Enabled = true;
            }
            replying = false;




        }

        private void nacitani_Tick(object sender, EventArgs e)
        {
            if (connection == false)
            {


                if (replying == false)
                {


                    konzole.Text = "Probíhá připojování k " + IP_text.Text + "";
                    if (tecka < 4)
                    {
                        konzole.Text += ".";
                        tecka++;
                    }
                    else
                    {
                        konzole.Text = "Probíhá připojování k " + IP_text.Text + "";
                    }
                }
            }
            else
            {
                konzole.Text = "Aplikace běží...";
                konzole.Text += "\nOpětovná kontrola proběhne za " + opakovani.ToString();
                opakovani--;
                
                

            }

        }

        private void konzole_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check_timer_Tick(object sender, EventArgs e)
        {
            DateTime cas = DateTime.Now;
            int hodina = int.Parse(hod2.Text);
            int minuta= int.Parse(min2.Text);
            if(cas.Hour == hodina && cas.Minute == minuta)
            {
                alarm.TopMost=true;
                alarm.TopLevel=true;
                alarm.StartPosition=FormStartPosition.CenterScreen;
                alarm.Show();
            }
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            not_save();


            StreamWriter psani = new StreamWriter(path_txt);
            psani.AutoFlush=true;
            psani.WriteLine(hod1.Text);
            psani.WriteLine(hod2.Text);
            psani.WriteLine(min1.Text);
            psani.WriteLine(min2.Text);
            psani.Close();
        }

        private void min1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            not_save();
            string cesta = "AdressIPV4.txt";
            StreamWriter sw = new StreamWriter(cesta);
            sw.AutoFlush=true;
            sw.WriteLine(IP_text.Text);
            sw.Close();
        }

        private void Slider_tick_Tick(object sender, EventArgs e)
        {
            if(open == false)
            {
                this.Width+=15;
                if (this.Width == this.MaximumSize.Width)
                {
                    Slider_tick.Stop();
                    open = true;

                }

            }
            if(open == true)
            {
                this.Width-=15;
                if (this.Width == this.MinimumSize.Width)
                {
                    Slider_tick.Stop();
                    open = false;

                }
            }
            
        }

        private void slider_Click(object sender, EventArgs e)
        {
            Slider_tick.Start();
        }

        void not_save()
        {
            
            label.AutoSize = false;
            if(open == true)
            {
             label.Width = 722;
             label.Height = 16;
             label.Location = new Point(0, 204);
                label.Text = "Uloženo";
            }
            else
            {

              label.Width = 337;
              label.Height = 16;
              label.Location = new Point(0, 204);
                label.Text = "Uloženo";

            }
           
            label.BackColor = Color.Green;
            label.ForeColor = Color.White;
            label.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold);
            
            this.Controls.Add(label);
            System.Windows.Forms.Timer vypnout = new System.Windows.Forms.Timer();
            
            vypnout.Tick += new EventHandler(vypinac);
            vypnout.Interval = 1;
            vypnout.Start();

        }

        private void vypinac(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer time = sender as System.Windows.Forms.Timer;
            label.Width -= 3;
            time.Interval = 1;
            if (label.Width == 0)
            {
                this.Controls.Remove(label);
                time.Stop();
            }
            
        }

        private void hod2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            IP_text.Text = "10.0.0.140";
            hod1.Text = "9";
            hod2.Text = "10";
            min1.Text = "00";
            min2.Text = "21";
        }
    }
}
