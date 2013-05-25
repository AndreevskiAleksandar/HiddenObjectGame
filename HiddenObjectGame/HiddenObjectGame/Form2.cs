using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HiddenObjectGame
{
    public partial class Form2 : Form
    {
        public int count;
        public int info;

        public Form2(int info)
        {
            InitializeComponent();
            count = 0;
            this.info = info;
            switch (info)
            {
                case 1:
                    richTextBox1.Text = "Hey You! Over here.. Do not worry you are not in prison. I bet you are wondering why I 've brought you here?";
                    button1.Text = "Yes, yes I am..";
                    break;
                case 2:
                    richTextBox1.Text = "Hey hey hey! Great Job! See? That wasn't too hard. Come on this time we are going to a more open location";
                    button1.Text = "Okay. But a question first.";        
                    break;
                case 3:
                    richTextBox1.Text = "Fantastic! Only one more scene to go.. Next we go to a special place for me..";
                    button1.Text = "Where is that?";
                    break;
                case 4:
                    richTextBox1.Text = "You did it! You found all the items i need!";
                    button1.Text = "Huh.. Now speak.. Why all this?";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;

            switch (info)
            {
                case 1:
                    switch (count)
                    {
                        case 1:
                            richTextBox1.Text = "Let me explain you. First of all as you can see I am a wisp. A ghost if you will. I can not tell you yet everything but I will tell you this: You need to find some things for me";
                            button1.Text = "What kind of things?";
                            break;
                        case 2:
                            richTextBox1.Text = "Some stuff I need.. They are around here somewhere.. I think..";
                            button1.Text = "And why should I help you?";
                            break;
                        case 3:
                            richTextBox1.Text = "Because if you don't help me, I will leave you in this jail!";
                            button1.Text = "Oh.. Since you put it that way..";
                            break;
                        case 4:
                            richTextBox1.Text = "That's more like it! Here is what you do. Just find the 10 items from the list on the right in the scene. To make it more fun to you I 've put a score counter for you. Yeey. +100 points if you find the item, -20 if you miss it. Oh and you can ask me for a hint and I 'll tell you where an item is. But careful only one hint per scene and no points for that!";
                            button1.Text = "Ok got it. Lets do this..";
                            break;
                        case 5:
                            this.Close();
                            break;
                    }
                    break;
                case 2:
                    switch (count)
                    { 
                        case 1:
                            richTextBox1.Text = "Yes? What is it that you want?";
                            button1.Text = "Why do you need all this?";
                            break;
                        case 2:
                            richTextBox1.Text = "...Even if I tell you it would not matter... You would not understand..";
                            button1.Text = "Try explaining";
                            break;
                        case 3:
                            richTextBox1.Text = "How about this. Finish the last level and I will tell you.. You are not far from it! Deal?";
                            button1.Text = "Deal!";
                            break;
                        case 4:
                            this.Close();
                            break;
                    }
                    break;
                case 3:
                    switch (count)
                    { 
                        case 1:
                            richTextBox1.Text = "A room... Follow me.. I will explain short after";
                            button1.Text = "Okay..";
                            break;
                        case 2:
                            this.Close();
                            break;
                    }
                    break;
                case 4:
                    switch (count)
                    { 
                        case 1:
                            richTextBox1.Text = "Okay okay.. A deal is a deal.. You see the room we are in is the last room i saw... while I was alive.. Yes I died here. Or to say it better: I WAS MURDERED HERE!";
                            button1.Text = "I.. I didn't know that.";
                            break;
                        case 2:
                            richTextBox1.Text = "It is ok.. I have been roaming this places ever since..";
                            button1.Text = "But why all this items?";
                            break;
                        case 3:
                            richTextBox1.Text = "I need to find my killer.. I can not rest until then. They are required for the ritual";
                            button1.Text = "Ritual? What ritual?";
                            break;
                        case 4:
                            richTextBox1.Text = "You already know too much.. I am sorry for choosing you to help me find these items but I could not have done it by myself";
                            button1.Text = "I see.. Now what happens?";
                            break;
                        case 5:
                            richTextBox1.Text = "Now I will do what I have to do and you will find yourself safe in your room as you were before.. Goodbye and thank you.";
                            button1.Text = "No... Wait!";
                            break;
                        case 6:
                            this.Close();
                            break;
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
