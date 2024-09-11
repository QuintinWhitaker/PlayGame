using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Error_Click(object sender, EventArgs e)
        {

            SoundPlayer sp = new SoundPlayer(Properties.Resources.TV_Static_Mike_Koenig_1287909192);
            sp.Play();

            Error.Text = "3";
            Refresh();
            Thread.Sleep(1000);

            Error.Text = "2";
            Refresh();
            Thread.Sleep(1000);

            Error.Text = "1";
            Refresh();
            Thread.Sleep(1000);

            Error.Text = "Go!";
            Refresh();
            Thread.Sleep(1000);
            
           






        }
    }
}
