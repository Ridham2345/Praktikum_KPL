using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_2211104016
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private string operation = "";
        private bool isOperationPerformed = false;
        private TextBox displayTextBox; // Referensi ke TextBox

        public Form1()
        {
            InitializeComponent();
            InitializeCalculator();
        }

        private void InitializeCalculator()
        {
            this.Text = "Simple Calculator";
            this.Size = new Size(300, 400);

            // Inisialisasi TextBox
            displayTextBox = new TextBox
            {
                Name = "textBox1",
                Location = new Point(50, 50),
                Size = new Size(200, 30),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right
            };
            this.Controls.Add(displayTextBox);

            // Inisialisasi Button
            string[] buttonTexts = { "7", "8", "9", "4", "5", "6", "1", "2", "3", "0" };
            int x = 50, y = 100;

            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button
                {
                    Text = buttonTexts[i],
                    Location = new Point(x + (i % 3) * 50, y + (i / 3) * 50),
                    Size = new Size(50, 50)
                };
                btn.Click += (sender, e) => AppendNumber(((Button)sender).Text);
                this.Controls.Add(btn);
            }

            Button addButton = new Button
            {
                Text = "+",
                Location = new Point(200, 100),
                Size = new Size(50, 50)
            };
            addButton.Click += buttonAdd_Click;
            this.Controls.Add(addButton);

            Button equalButton = new Button
            {
                Text = "=",
                Location = new Point(200, 150),
                Size = new Size(50, 50)
            };
            equalButton.Click += buttonEqual_Click;
            this.Controls.Add(equalButton);
        }

        private void AppendNumber(string number)
        {
            if (isOperationPerformed)
            {
                displayTextBox.Text = "";
                isOperationPerformed = false;
            }
            displayTextBox.Text += number;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out firstNumber))
            {
                operation = "+";
                isOperationPerformed = true;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double secondNumber) && !string.IsNullOrEmpty(operation))
            {
                double result = 0;
                if (operation == "+")
                {
                    result = firstNumber + secondNumber;
                }
                displayTextBox.Text = result.ToString();
                operation = "";
                isOperationPerformed = true;
            }
            else
            {
                MessageBox.Show("Invalid input or operation!");
            }
        }

        // Event handler untuk tombol lain (opsional, jika menggunakan Designer)
        private void button1_Click(object sender, EventArgs e) { AppendNumber("1"); }
        private void button2_Click(object sender, EventArgs e) { AppendNumber("2"); }
        private void button3_Click(object sender, EventArgs e) { AppendNumber("3"); }
        private void button4_Click(object sender, EventArgs e) { AppendNumber("4"); }
        private void button5_Click(object sender, EventArgs e) { AppendNumber("5"); }
        private void button6_Click(object sender, EventArgs e) { AppendNumber("6"); }
        private void button7_Click(object sender, EventArgs e) { AppendNumber("7"); }
        private void button8_Click(object sender, EventArgs e) { AppendNumber("8"); }
        private void button9_Click(object sender, EventArgs e) { AppendNumber("9"); }
        private void button11_Click(object sender, EventArgs e) { AppendNumber("0"); }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Tidak perlu logika khusus di sini kecuali validasi tambahan
        }
    }
}