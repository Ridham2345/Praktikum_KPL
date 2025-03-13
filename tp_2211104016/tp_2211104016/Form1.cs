using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_2211104016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
            this.Text = "Form Input Nama";
            this.Size = new Size(400, 200);

            if (textBox1 != null)
            {
                textBox1.Location = new Point(50, 50);
                textBox1.Size = new Size(200, 20); 
            }

            if (button1 != null)
            {
                button1.Location = new Point(260, 48); 
                button1.Size = new Size(75, 23);
            }

            if (label1 != null)
            {
                label1.Location = new Point(50, 80);
                label1.Size = new Size(300, 20);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Halo " + textBox1.Text.Trim();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            textBox1.Size = new Size(250, 50);

           
            if (button1 != null)
            {
                button1.Location = new Point(textBox1.Right + 10, button1.Location.Y); 
        
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}