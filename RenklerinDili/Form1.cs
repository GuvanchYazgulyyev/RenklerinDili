using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenklerinDili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Guga"&& textBox2.Text == "123")
            {
                Form2 renkfotrm = new Form2();
                renkfotrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Hatalı!!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 renk = new Form2();
            renk.Show();
            this.Hide();
        }
    }
}
