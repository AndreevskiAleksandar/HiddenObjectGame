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
    public partial class Form3 : Form
    {
        public string name { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Please Enter Your Name");
            }
            else
            {
             errorProvider1.SetError(textBox1, "");
            }
        }

        private void button1_Validating(object sender, CancelEventArgs e)
        {
            ValidateChildren(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.name = textBox1.Text.Trim();
            this.Close();
        }


    }
}
