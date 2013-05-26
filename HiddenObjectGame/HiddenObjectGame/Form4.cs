using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace HiddenObjectGame
{
    public partial class Form4 : Form
    {
        public Form4(Form1 f)
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                //string s = String.Format("{0} {1,15}", f.h.names[i], f.h.scores[i]);
                if (f.h.names[i] != null)
                    dataGridView1.Rows.Add(f.h.names[i],f.h.scores[i]);
                    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
