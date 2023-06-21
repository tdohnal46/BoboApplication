using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Noifikace_bobo
{
    public partial class Notifikace_timer : Form
    {
        public Notifikace_timer()
        {
            InitializeComponent();
            conn.Open();
           
        }
        int pocet = 0;
        int Konecpocet = 0;

        SqlConnection conn = new SqlConnection("");

       

        string mailik;
        int pocetMail;
        int index = 1;
        int pocet_obedu;
        string zprava;
        int suma;
       
        private void Form1_Load(object sender, EventArgs e)
        {


            System.Windows.Forms.Timer casovac = new System.Windows.Forms.Timer();
            casovac.Interval = 60000;
            casovac.Tick += new EventHandler(timer_Tick);
            casovac.Start();
            
            BeginInvoke(new MethodInvoker(delegate
            {
                Hide();
            }));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime den = DateTime.Today;




            if (den.ToString("dddd") != "sobota" && den.ToString("dddd") != "neděle")
            {


                DateTime realtime = DateTime.Now;
                if (realtime.Hour == 9 && realtime.Minute == 0)
                {
                    //if (pocet == 0)
                    //{
                    //    otevreni_obed();
                       
                    //    pocet++;
                    //}
                }

                if (realtime.Hour > 10 && realtime.Minute > 21 || realtime.Hour == 10 && realtime.Minute == 21)
                {

                    if (Konecpocet == 0)
                    {
                        Uzavreni_obed();
                        if (realtime.Hour == 10 && realtime.Minute == 21)
                        {
                            
                                odeslani_obed();
                           
                           
                        }
                        Konecpocet++;
                    }
                }
                if (realtime.Hour < 9)
                {
                    Konecpocet = 0;
                    pocet = 0;
                }
            }
        }



        // TODO: Tento řádek načte data do tabulky 'loginyDataSet6.obed'. Můžete jej přesunout nebo jej odstranit podle potřeby.





        string nastaveniBOOL;
        void otevreni_obed()
        {
           
           
            SqlCommand cmd = new SqlCommand("SELECT email,notifikace FROM Login GROUP BY email,notifikace ", conn);


            SqlDataReader rd = cmd.ExecuteReader();





            while (rd.Read())
            {

                mailik = rd[0].ToString();

                nastaveniBOOL = rd[1].ToString();





                if (nastaveniBOOL == "ano")
                {
                  


                    using (MailMessage mail = new MailMessage("bobo.app.report@gmail.com", mailik, "Notifikace: Můžete si již objednat oběd ", "Oběd si můžete objednat do 10:20."))
                    {
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {


                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("bobo.app.report@gmail.com", "pchgsnxdbqzqmntm");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);



                        }
                    };
                }

            }

            rd.Close();

           

        }
        void Uzavreni_obed()
        {
            ;
            ;


            SqlCommand cmd = new SqlCommand("Update Otevreni_obed SET stav_obedu='zavreno'", conn);
            cmd.ExecuteNonQuery();
            //SqlCommand cmd = new SqlCommand("SELECT email,notifikace FROM Login GROUP BY email,notifikace ", conn);
            //SqlDataReader rd = cmd.ExecuteReader();

            //while (rd.Read())
            //{
            //    mailik = rd[0].ToString();

            //    nastaveniBOOL = rd[1].ToString();

            //    if (nastaveniBOOL == "ano")
            //    {



            //        DateTime zitra = DateTime.Today.AddDays(1);
            //        using (MailMessage mail = new MailMessage("bobo.app.report@gmail.com", mailik, "Notifikace: Oběd již nelze objednat", "Oběd si můžete opět objednat zítra " + zitra.ToString("d") + "."))
            //        {
            //            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            //            {


            //                smtp.UseDefaultCredentials = false;
            //                smtp.Credentials = new NetworkCredential("bobo.app.report@gmail.com", "pchgsnxdbqzqmntm");
            //                smtp.EnableSsl = true;
            //                smtp.Send(mail);
            //            }
            //        }
            //    }
            //}

        }


        void odeslani_obed()
        {

            int pocet_objednavek = 0;


            DateTime dneska = DateTime.Today;
            SqlCommand odeslani = new SqlCommand("SELECT Jídlo,Příloha,COUNT(Jídlo) pocet FROM Obedy WHERE Datum = '"+dneska.ToString("yyyy-MM-dd")+"' GROUP BY Jídlo,Příloha", conn);
            SqlDataReader read = odeslani.ExecuteReader();
            while (read.Read())
            {
                if (read[1].ToString() == "Žádné")
                {
                    zprava += "<p><strong>      • " + read[0].ToString() + "</strong> - <b>" + read[2].ToString() + "x</b></p>";
                }
                if (read[1].ToString() != "Žádné")
                {
                    zprava += "<p><strong>      • " + read[0].ToString() + "</strong> - <b>" + read[2].ToString() + "x</b>" + ", <font size=3 color=red>Změna přílohy: " + read[1].ToString() + "</font></p>";
                }
                pocet_objednavek++;


            }
            read.Close();
            SqlCommand Suma = new SqlCommand("SELECT Count(*) FROM Obedy WHERE Datum = '"+dneska.ToString("yyyy-MM-dd")+"'", conn);
            SqlDataReader sumarum = Suma.ExecuteReader();
            while (sumarum.Read())
            {
                suma = (int)sumarum[0];
                    
            }
            sumarum.Close();
            
            using (MailMessage mail = new MailMessage("bobo.app.report@gmail.com", "michaelkasvarcova@seznam.cz", "Objednávka SANITINO", "Dobrý den,\n\nmáme zájem si u Vás objednat:\n" + zprava + "\n_______________________________________________\nCelkový počet objednávek: " + suma.ToString()+ "\n\r\n\rDěkujeme a přejeme příjemný zbytek dne\n\r\n\r\n\rKontaktní osoba\n_______________________________________________\nNikol Záškolná\n✆ +420 777 333 222\n✉ nikol.zaskolna@sanitino.cz\nMlýnská, Hostomice 417 52, firma Sanitino  \r\n\r\nwww.sanitino.cz \r\n\r\n"))
            {
                //
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {

                    mail.IsBodyHtml = true;

                    mail.Body = " <p>Dobrý den,</p>" +
                        "<p>prosím o objednávku jídla:</p><br></br>" +
                        ""+"<p>" + zprava +"</p>"+
                        "<p style=color:blue>_______________________________________________</p>" +
                        "<p><font size=4 color=#00BFFF><b>Celkový počet objednávek: </font><font size=5 color=black><b>" + suma.ToString()+"</b></font></h1>"+ "<br></br>" +
                        "<p>Děkujeme a přejeme příjemný zbytek dne</p>" +
                        //"<p>Kontaktní osoba</p>" +
                        "<p style=color:blue>_______________________________________________</p>" +
                        "<foot><p><font size=5 color=#A9A9A9><b>Nikol Záškolná</b></font></p>" +
                        "<p><article><font size=2 color=#00BFFF><b>✆ +420 604 708 796</b></font></p>" +
                        "<p><font size=2 color=#00BFFF><b>✉ nikol.zaskolna@sanitino.cz</b></font></p>" +
                        "<p><font size=2 color=#00BFFF><b>Mlýnská, Hostomice 417 52, firma Sanitino</font></b></article></p>" +
                        "<p style=color:#00BFFF><b>www.sanitino.cz</b></p>" +
                        "<img src = https://files.netorg.cz/images/25777/detail_logo.jpg.png alt = logo></foot>";
                    
  
                    

                    //mail.Headers["Content-Type"] ="ahoj";
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("bobo.app.report@gmail.com", "pchgsnxdbqzqmntm");
                    smtp.EnableSsl = true;

                    if(pocet_objednavek > 0)
                    {
                        smtp.Send(mail);
                        
                    }
                  

                    smtp.Send(mail);

                }

            }
            zprava = "";
           
        }

    }
}
