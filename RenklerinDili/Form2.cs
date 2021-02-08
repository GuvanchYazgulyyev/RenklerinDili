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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Mavi")
            {
                label4.Text = textBox1.Text + " " + comboBox2.Text + "rengi=" + "Mutlulugun ve pozitifligin rengidir.";
                button2.BackColor = Color.Blue;
            }
            if (comboBox2.Text == "Sarı")
            {
                label4.Text = textBox1.Text + " " + comboBox2.Text + "rengi=" + "iyimserligin rengidir:";
                button2.BackColor = Color.Yellow;
            }
            if (comboBox2.Text == "Kırmızı")
            {
                label4.Text = textBox1.Text + " " + comboBox2.Text + "rengi=" + "Şehvet,Arzu rengidir!";
                button2.BackColor = Color.Red;
            }
            if (comboBox2.Text == "Siyah")
            {
                label4.Text = textBox1.Text + " " + comboBox2.Text + "rengi=" + "Kötümserligin rengi";
                button2.BackColor = Color.Black;
            }
        }
    }
}
