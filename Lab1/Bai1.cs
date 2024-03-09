using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
         private void tinhtong(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            if (!(Int32.TryParse(textBox1.Text, out num1))|| !(Int32.TryParse(textBox2.Text, out num2)))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
            else
            {
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
                
            }
        }
        private void xoa(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }

        private void thoat(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
