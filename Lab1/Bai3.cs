using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
<<<<<<< HEAD
=======
using System.Diagnostics.Eventing.Reader;
>>>>>>> ff48352fd599ddace8298bf4708a6a5b5a6ba8bf
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
<<<<<<< HEAD
=======
            Ketqua.ResetText();
>>>>>>> ff48352fd599ddace8298bf4708a6a5b5a6ba8bf
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doc_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            int num;
            if (!(int.TryParse(SoNguyen.Text, out num)))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
            else
            {
                string a = num.ToString();
                string kq = "";
                string[] hang1 = new string[3] { "", "mươi", "trăm" };
                string[] hang2 = new string[4] { "", "nghìn", "triệu", "tỷ"};
                string[] numstring = new string[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    if (i == 0)
                    {
                        if (a[i] == '1') numstring[i] = "Một";
                        else if (a[i] == '2') numstring[i] = "Hai";
                        else if (a[i] == '3') numstring[i] = "Ba";
                        else if (a[i] == '4') numstring[i] = "Bốn";
                        else if (a[i] == '5') numstring[i] = "Năm";
                        else if (a[i] == '6') numstring[i] = "Sáu";
                        else if (a[i] == '7') numstring[i] = "Bảy";
                        else if (a[i] == '8') numstring[i] = "Tám";
                        else numstring[i] = "Chín";
                    }
                    else
                    {
                        if (a[i] == '0') numstring[i] = "không";
                        else if (a[i] == '1') numstring[i] = "một";
                        else if (a[i] == '2') numstring[i] = "hai";
                        else if (a[i] == '3') numstring[i] = "ba";
                        else if (a[i] == '4') numstring[i] = "bốn";
                        else if (a[i] == '5') {
                            if ((i == (a.Length - 1)) && (a.Length != 1) && (a[i - 1] != '0')) {
                                numstring[i] = "lăm";
                            }
                            else numstring[i] = "năm";
                        }
                        else if (a[i] == '6') numstring[i] = "sáu";
                        else if (a[i] == '7') numstring[i] = "bảy";
                        else if (a[i] == '8') numstring[i] = "tám";
                        else numstring[i] = "chín";
                    }
                    
                }
                
                for (int i = 0; i < a.Length;i++)
                {
                    if ((numstring[i] == "một") && ((a.Length - 1 - i) % 3 == 1))
                    {
                        kq += "mười";
                        if ((a.Length - 1 - i) % 3 == 0) kq = kq + hang2[(int)((a.Length - 1 - i) / 3)] + " ";
                    }
                    else if ((numstring[i] == "một") && ((a.Length - 1 - i) % 3 != 1))
                    {
                        kq = kq + numstring[i] + " ";
                        if (hang1[(a.Length - 1 - i) % 3] != "") kq = kq + hang1[(a.Length - 1 - i) % 3] + " ";
                        if ((a.Length - 1 - i) % 3 == 0) kq = kq + hang2[(int)((a.Length - 1 - i) / 3)] + " ";
                    }
                    else
                    {
                        if ((numstring[i] == "không") && ((a.Length - 1 - i) % 3 == 2))
                        {
                            if ((numstring[i + 1] != "không") || (numstring[i + 2] != "không"))
                            {
                                kq = kq + numstring[i] + " ";
                                kq = kq + hang1[(a.Length - 1 - i) % 3] + " ";
                            }
                        }
                        else if ((numstring[i] == "không") && ((a.Length - 1 - i) % 3 == 1))
                        {
                            if (numstring[i + 1] != "không") kq = kq + "lẻ" + " ";
                        }

                        else
                        {
                            if (numstring[i] != "không")
                            {
                                kq = kq + numstring[i] + " ";
                                if (hang1[(a.Length - 1 - i) % 3] != "") kq = kq + hang1[(a.Length - 1 - i) % 3] + " ";
                                if (((a.Length - 1 - i) % 3 == 0) && (i != (a.Length - 1))) kq = kq + hang2[(int)((a.Length - 1 - i) / 3)] + " ";
                            }
                            else
                            {
                                if (((a.Length - 1 - i) % 3 == 0) && (i != (a.Length - 1)))
                                {
                                    kq = kq + hang2[(int)((a.Length - 1 - i) / 3)] + " ";
                                    int cnt = 0;
                                    for (int j = i + 1; j < a.Length; j++)
                                    {
                                        if (numstring[j] == "không") cnt += 1;
                                    }
                                    if (cnt == (a.Length - 1 - i)) break;
                                }
                            }
                        }
                    }
                }
                Ketqua.Text = kq;
            }
>>>>>>> ff48352fd599ddace8298bf4708a6a5b5a6ba8bf
        }
    }
}
