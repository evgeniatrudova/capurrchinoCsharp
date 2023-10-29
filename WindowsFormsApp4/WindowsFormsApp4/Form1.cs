using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalSum;
            int paidSum;

            if (int.TryParse(textBox1.Text, out totalSum) && int.TryParse(textBox2.Text, out paidSum))
            {
                int changeBack = paidSum - totalSum;

                
                test1_changeback_lbl.Text = changeBack.ToString();
            }
            else
            {
                test1_changeback_lbl.Text = "Invalid Input";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int changeBack = 0;
            test1_changeback_lbl.Text = changeBack.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
    }
}
