using System;
using System.Windows.Forms;

namespace Ucgen_Olma_Kurali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        double c;
        double d;
        double f;

        private void button1_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            d = a - b;
            f = a + b;

            if (c > d && c < f)
                label4.Text = "Bu Bir Üçgendir";
            else
                label4.Text = "Bu Bir Üçgen Değildir";
        }

    }
}
