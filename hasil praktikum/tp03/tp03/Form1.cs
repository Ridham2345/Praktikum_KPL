using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Inisialisasi awal UI (jika belum ada di designer)
            this.Text = "Form Input Nama";
            this.Size = new Size(300, 200);

            // Tambahkan kontrol jika belum ada di designer
            if (textBox2 == null)
            {
                textBox2 = new TextBox
                {
                    Name = "textBox2",
                    Location = new Point(100, 50),
                    Size = new Size(150, 20)
                };
                this.Controls.Add(textBox2);
            }

            if (label1 == null)
            {
                label1 = new Label
                {
                    Name = "label1",
                    Location = new Point(100, 80),
                    Size = new Size(200, 20)
                };
                this.Controls.Add(label1);
            }

            if (button1 == null)
            {
                button1 = new Button
                {
                    Name = "button1",
                    Text = "Submit",
                    Location = new Point(125, 110),
                    Size = new Size(75, 23)
                };
                button1.Click += new EventHandler(button1_Click);
                this.Controls.Add(button1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mengambil teks dari textBox2 dan menampilkannya di label1
            string nama = textBox2.Text.Trim(); // Menghapus spasi berlebih
            if (string.IsNullOrEmpty(nama))
            {
                label1.Text = "Silakan masukkan nama!";
            }
            else
            {
                label1.Text = "Halo " + nama;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Opsional: Hapus perubahan ukuran jika tidak diperlukan
            // textBox2.Size = new Size(200, 50); // Komentari atau hapus jika tidak dibutuhkan
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Kosongkan jika tidak digunakan
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kosongkan jika tidak digunakan
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kosongkan jika tidak digunakan
        }
    }
}