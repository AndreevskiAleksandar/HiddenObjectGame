using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using HiddenObjectGame.Properties;

namespace HiddenObjectGame
{

    public partial class Form1 : Form
    {
        
        Brush b;
        Bitmap bit;
        

        public Form1()
        {
            InitializeComponent();
            b = new SolidBrush(Color.LightGreen);
            bit = new Bitmap(Resources.hidden_object_bedroom_final);
            pictureBox1.Image = bit;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (var gr = Graphics.FromImage(pictureBox1.Image))
            {
                gr.DrawEllipse(new Pen(b, 2), 43, 520, 50, 60);

            }
        
        }
    }
}
