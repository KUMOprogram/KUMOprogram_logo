using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyLOGO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int metritis = 0;
        int mytimer = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++mytimer;

            if (metritis == 0)
            {
                pictureBox1.Left += 8;
                pictureBox1.Top += 4;
                if (mytimer == 60)
                {
                    metritis = 1;
                }
            }

            if (metritis == 1)
            {
                pictureBox1.Left += 0;
                pictureBox1.Top -= 5;
                if (mytimer == 85)
                {
                    metritis = 2;
                }
            }

            if (metritis == 2)
            {
                pictureBox1.Left -= 5;
                pictureBox1.Top += 5;
                if (mytimer == 120)
                {
                    metritis = 3;
                }
            }

            if (metritis == 3)
            {
                pictureBox1.Left += 0;
                pictureBox1.Top -= 5;
                if (mytimer == 160)
                {
                    metritis = 4;
                }
            }

            if (metritis == 4)
            {               
                pictureBox1.Size = new Size(pictureBox1.Size.Width + 18, pictureBox1.Size.Height + 18);
                pictureBox1.Left -= 9;
                pictureBox1.Top -= 5;
                if (mytimer == 230)
                {
                    metritis = 5;
                }
            }

            if (metritis == 5)
            {
                pictureBox2.Visible = true;
                if (mytimer == 400)
                {
                    metritis = 6;
                }
            }

            if (metritis == 6)
            {
                //this.Hide();
                this.Close();
            }
        }
    }
}
