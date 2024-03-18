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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void thoat(object sender, EventArgs e)
        {
            //thoát
            this.Close();
        }

        private void xoa(object sender, EventArgs e)
        {
            //Xóa
            sothu1.ResetText();
            sothu2.ResetText();
            sothu3.ResetText();
            solonnhat.ResetText();
            sonhonhat.ResetText();
        }

        private void tim(object sender, EventArgs e)
        {
            float num1, num2, num3;
            if (!(float.TryParse(sothu1.Text, out num1)) || !(float.TryParse(sothu2.Text, out num2)) || !(float.TryParse(sothu3.Text, out num3)))
            {
                MessageBox.Show("Vui lòng nhập số!");
                return;
            }
            else
            {
                float max = float.MinValue;
                float min = float.MaxValue;
                if (num1 > num2)
                {
                    max = num1;
                    min = num2;
                }
                else
                {
                    max = num2;
                    min = num1;
                }
                if (num3 > max)
                {
                    max = num3;
                }
                if (num3 < min)
                {
                    min = num3;
                }
                solonnhat.Text = max.ToString();
                sonhonhat.Text = min.ToString();
            }
            
        }
    }
}
