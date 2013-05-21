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
        int level = 1;
        GameObjects game;
        
        public Form1()
        {
            InitializeComponent();
            label1.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            label2.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            label3.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            label4.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            label5.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            label6.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            label7.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            label8.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            label9.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            label10.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            label11.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            label12.Font = new Font("Lucida Sans", 12f, FontStyle.Regular);
            b = new SolidBrush(Color.LightGreen);
            newGame();
        }

        void newGame()
        {
            game = new GameObjects(level);
            switch (level)
            {
                case 1:
                    Form2 f = new Form2(1);
                    f.ShowDialog();
                    this.BackColor = Color.Gainsboro;
                    bit = new Bitmap(Resources.hidden_object_prison_final);
                    label1.Text = "Spider";
                    label2.Text = "Stones";
                    label3.Text = "Pinecone";
                    label4.Text = "Bucket";
                    label5.Text = "Phone";
                    label6.Text = "Skull";
                    label7.Text = "Brush";
                    label8.Text = "Skrew";
                    label9.Text = "Knife";
                    label10.Text = "Golden Bell";
                    MessageBox.Show("                                                           First Level \n(If you want to skip the conversation with the wisp just click the red x (close) button in the top right corner)");
                    break;
                case 2:
                    Form2 f2 = new Form2(2);
                    f2.ShowDialog();
                    MessageBox.Show("Halfway there.. Level Two");
                    this.BackColor = Color.DarkKhaki;
                    if (button1.Enabled == false)
                    {
                        button1.Enabled = true;
                        button1.Text = "Hint";
                    }
                    bit = new Bitmap(Resources.hidden_object_front_door_final);
                    label1.Text = "Seashell";
                    label2.Text = "Turtle";
                    label3.Text = "Lightbulb";
                    label4.Text = "Cactus";
                    label5.Text = "Jar Of Pennies";
                    label6.Text = "Donut";
                    label7.Text = "Toy Boxes";
                    label8.Text = "Military Helm";
                    label9.Text = "Trumpet";
                    label10.Text = "Candles";
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
                    label2.Font = new Font(label2.Font, FontStyle.Regular);
                    label3.Font = new Font(label3.Font, FontStyle.Regular);
                    label4.Font = new Font(label4.Font, FontStyle.Regular);
                    label5.Font = new Font(label5.Font, FontStyle.Regular);
                    label6.Font = new Font(label6.Font, FontStyle.Regular);
                    label7.Font = new Font(label7.Font, FontStyle.Regular);
                    label8.Font = new Font(label8.Font, FontStyle.Regular);
                    label9.Font = new Font(label9.Font, FontStyle.Regular);
                    label10.Font = new Font(label10.Font, FontStyle.Regular);
                    
                    break;
                case 3:
                    Form2 f3 = new Form2(3);
                    f3.ShowDialog();
                    MessageBox.Show("Last Level");
                    this.BackColor = Color.Chocolate;
                    if (button1.Enabled == false)
                    {
                        button1.Enabled = true;
                        button1.Text = "Hint";
                    }
                    bit = new Bitmap(Resources.hidden_object_bedroom_final);
                    label1.Text = "Pepper";
                    label2.Text = "Salt";
                    label3.Text = "Crayons";
                    label4.Text = "Tiger";
                    label5.Text = "Shrimp";
                    label6.Text = "Clock";
                    label7.Text = "Apple";
                    label8.Text = "MailBox";
                    label9.Text = "Ship In A Bottle";
                    label10.Text = "Grey Glove";
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
                    label2.Font = new Font(label2.Font, FontStyle.Regular);
                    label3.Font = new Font(label3.Font, FontStyle.Regular);
                    label4.Font = new Font(label4.Font, FontStyle.Regular);
                    label5.Font = new Font(label5.Font, FontStyle.Regular);
                    label6.Font = new Font(label6.Font, FontStyle.Regular);
                    label7.Font = new Font(label7.Font, FontStyle.Regular);
                    label8.Font = new Font(label8.Font, FontStyle.Regular);
                    label9.Font = new Font(label9.Font, FontStyle.Regular);
                    label10.Font = new Font(label10.Font, FontStyle.Regular);
                 
                    break;
                case 4:
                    Form2 f4 = new Form2(4);
                    f4.ShowDialog();
                    MessageBox.Show("Yey... You Won ^_^ \nYour score is: "+label12.Text);
                    Close();
                    break;
            }
            pictureBox1.Image = bit;
        }

        void checkNewGame()
        {
            bool flag = true;
            for (int i = 0; i < game.lista.Count; i++)
            {
                if (!game.lista[i].isHit)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                level++;
                newGame();
            }
        }


        void updateLabels(int i)
        {
            switch (i)
            {
                case 0:
                    label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Strikeout);
                    break;
                case 1:
                    label2.Font = new Font(label2.Font, label2.Font.Style | FontStyle.Strikeout);
                    break;
                case 2:
                    label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Strikeout);
                    break;
                case 3:
                    label4.Font = new Font(label4.Font, label4.Font.Style | FontStyle.Strikeout);
                    break;
                case 4:
                    label5.Font = new Font(label5.Font, label5.Font.Style | FontStyle.Strikeout);
                    break;
                case 5:
                    label6.Font = new Font(label6.Font, label6.Font.Style | FontStyle.Strikeout);
                    break;
                case 6:
                    label7.Font = new Font(label7.Font, label7.Font.Style | FontStyle.Strikeout);
                    break;
                case 7:
                    label8.Font = new Font(label8.Font, label8.Font.Style | FontStyle.Strikeout);
                    break;
                case 8:
                    label9.Font = new Font(label9.Font, label9.Font.Style | FontStyle.Strikeout);
                    break;
                case 9:
                    label10.Font = new Font(label10.Font, label10.Font.Style | FontStyle.Strikeout);
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (var gr = Graphics.FromImage(pictureBox1.Image))
            {
                for (int i = 0; i < game.lista.Count;i++ )
                    if(game.lista[i].isHit)
                    gr.DrawEllipse(new Pen(b, 2), game.lista[i].x_position, game.lista[i].y_position, game.lista[i].radius_x, game.lista[i].radius_y);
            }
        
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            bool flag = false;
            int tmp=0;
            for (int i = 0; i < game.lista.Count; i++)
            {
                if (!game.lista[i].isHit && (((e.X - (game.lista[i].x_position+game.lista[i].radius_x/2)) * (e.X - (game.lista[i].x_position+game.lista[i].radius_x/2))) / ((game.lista[i].radius_x/2) * (game.lista[i].radius_x/2))
                    + ((e.Y - (game.lista[i].y_position+game.lista[i].radius_y/2)) * (e.Y - (game.lista[i].y_position+game.lista[i].radius_y/2))) / ((game.lista[i].radius_y/2) * (game.lista[i].radius_y/2))) <= 1)
                {
                    game.lista[i].isHit = true;
                    flag = true;
                    updateLabels(i);
                    break;
                }
            }

            Int32.TryParse(label12.Text.Trim(), out tmp);

            if (flag)
            {
                label12.Text = "" + (tmp + 100);
                checkNewGame();
            }
            else
                label12.Text = "" + (tmp - 20);

            Invalidate(true);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < game.lista.Count; i++)
            {
                if (!game.lista[i].isHit)
                {
                    game.lista[i].isHit = true;
                    updateLabels(i);
                    button1.Enabled = false;
                    button1.Text = "Out Of Hints";
                    break;
                }
            }

            Invalidate(true);
            checkNewGame();
        }
    }
}
