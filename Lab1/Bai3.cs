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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            SoNguyen.ResetText();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doc_Click(object sender, EventArgs e)
        {
            string num = SoNguyen.Text;
            string[] numstring = new string[num.Length]; 
            List<string> ketqua = new List<string>();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '0') numstring.Append("không");
                else if (num[i] == '1') numstring.Append("một");
                else if (num[i] == '2') numstring.Append("hai");
                else if (num[i] == '3') numstring.Append("ba");
                else if (num[i] == '4') numstring.Append("bốn");
                else if (num[i] == '5') numstring.Append("năm");
                else if (num[i] == '6') numstring.Append("sáu");
                else if (num[i] == '7') numstring.Append("bảy");
                else if (num[i] == '8') numstring.Append("tám");
                else if (num[i] == '9') numstring.Append("chín");
            }

            string[] hang = new string[4] {"", "mươi", "trăm", "nghìn" };

            for (int i = 0;i < numstring.Length;i++)
            {
                if (i == 0)
                {
                    ketqua.Append(numstring[i]);
                    ketqua.Append(" ");
                    ketqua.Append(hang[numstring.Length-i]);
                }
                else
                {
                     if (numstring[i] != "không")
                     {
                        ketqua.Append(numstring[i]);
                        ketqua.Append(" ");
                        ketqua.Append(hang[numstring.Length - i]);
                     }
                    else
                    {
                        
                    }
                }
            }
            for (int i = 0; i < numstring.Length; i++)
            {
                Console.Write(numstring[i]);
            }
            //Ketqua.Text = string.Join(" ", numstring);
        }
    }
}
