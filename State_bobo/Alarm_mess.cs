using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State_bobo
{
    public partial class Alarm_mess : Form
    {
        SoundPlayer alarm = new SoundPlayer("alarm.wav");
        public Alarm_mess()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            alarm.PlayLooping();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            alarm.Stop();
        }
    }
}
