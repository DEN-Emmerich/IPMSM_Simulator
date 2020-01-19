using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPMSM_Simulator
{

    public partial class Form1 : Form
    {

        double t = 0; //time
        UInt32 pole = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)    //system timer 1ms event
        {
            t++;
            Label_speed.Text = t.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)     //first load form event
        {
            DrawRotor();
        }

        private void Combo_pole_SelectedIndexChanged(object sender, EventArgs e)    //change number of poles event
        {
            if(Combo_pole.SelectedIndex == 0)
            {
                pole = 2;
                DrawRotor();
            }
            else if(Combo_pole.SelectedIndex == 1)
            {
                pole = 4;
                DrawRotor();
            }
            else if (Combo_pole.SelectedIndex == 2)
            {
                pole = 6;
                DrawRotor();
            }
            else if (Combo_pole.SelectedIndex == 3)
            {
                pole = 8;
                DrawRotor();
            }
        }

        private void DrawRotor()
        {
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(canvas);

            g.DrawEllipse(Pens.Black, Constants.ROTOR_X, Constants.ROTOR_Y, Constants.ROTOR_D, Constants.ROTOR_D);

            int i;
            UInt32 pole_angle = 360 / pole;
            UInt32 pole_pola = 0;
            for (i = 0; i < pole; i++)
            {
                if (pole_pola == 0)
                {
                    g.FillPie(Brushes.Blue, Constants.ROTOR_X, Constants.ROTOR_Y, Constants.ROTOR_D, Constants.ROTOR_D, i * pole_angle, pole_angle);
                    pole_pola = 1;
                }
                else
                {
                    g.FillPie(Brushes.Red, Constants.ROTOR_X, Constants.ROTOR_Y, Constants.ROTOR_D, Constants.ROTOR_D, i * pole_angle, pole_angle);
                    pole_pola = 0;
                }
            }

            g.Dispose();
            pictureBox1.Image = canvas;
        }
    }

    static class Constants
    {
        public const double Pi = 3.14159;
        public const UInt32 ROTOR_X = 10;
        public const UInt32 ROTOR_Y = 10;
        public const UInt32 ROTOR_D = 200;
    }
}
