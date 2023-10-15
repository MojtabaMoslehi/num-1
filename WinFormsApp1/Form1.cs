using System;

namespace WinFormsApp1
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
            try
            {
                int num = Int32.Parse(label2.Text);
                int sum = Int32.Parse(textBox1.Text);
                num = num + sum;
                label2.Text = num.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int num = Int32.Parse(label2.Text);
                int sum = Int32.Parse(textBox1.Text);
                if (num != 0)
                {
                    num = num - sum;
                    label2.Text = num.ToString();
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}