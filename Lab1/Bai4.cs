using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int num1;
            if (comboBox1.Text == "Hexadecimal")
            {
                int check = 0;
                char[] x = textBox1.Text.ToCharArray();
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (x[i] <= 70 && x[i] >= 65) check++;
                    if (x[i] <= 57 && x[i] >= 48) check++;
                    
                }
                if (check != textBox1.TextLength)
                {
                    MessageBox.Show("Vui lòng nhập đúng dạng hệ 16!");
                }
                else
                {
                    if (comboBox2.Text == "Decimal") HextoDec(textBox1.Text);
                    
                } 
                    
            }
            
            else if (comboBox1.Text == "Decimal") 
            {
                int num1;
                if (!(Int32.TryParse(textBox1.Text, out num1)))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên!");
                    return;
                }
                else
                {
                    if (comboBox1.Text == "Decimal")
                    {
                        if (comboBox2.Text == "Binary") DectoBin(num1);
                        else if (comboBox2.Text == "Hexadecimal") DectoHex(num1);
                        else textBox2.Text = textBox1.Text;
                    }
               
                }
                }
            else if (comboBox1.Text == "Binary")
            {
                int num1;
                if (!(Int32.TryParse(textBox1.Text, out num1)))
                {
                    MessageBox.Show("Vui lòng nhập đúng dạng nhị phân!");
                    return;
                }
                else
                {
                    int check = 0;
                    char[] str = textBox1.Text.ToCharArray();
                    for (int i = 0; i < textBox1.TextLength; i++)
                        if (str[i] == 48 || str[i] == 49) check++;
                    if (check != textBox1.TextLength)
                    {
                        MessageBox.Show("Vui lòng nhập số nguyên!");
                        return;
                    }
                    if (comboBox2.Text == "Decimal") BintoDec(num1);
                    else if (comboBox2.Text == "Hexadecimal") BintoHex(num1);
                    else textBox2.Text = textBox1.Text;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DectoBin(int a)
        {
            string x="";
            while (a != 0)
            {
                int y = a % 2;
                x += y.ToString() ;
                a = a/2;
            }
            char[] stringarray = x.ToCharArray();
            Array.Reverse(stringarray);
            textBox2.Text = new string(stringarray);
        }

        private void DectoHex(int a)
        {
            string x = "";
            while (a != 0)
            {
                int y = a % 16;
                if (y <= 9 ) x += y.ToString();
                else switch (y)
                    {
                        case 10: x += "A";break;
                        case 11: x += "B";break;
                        case 12: x += "C";break;
                        case 13: x += "D";break;
                        case 14: x += "E";break;
                        case 15: x += "F";break;
                    }
                a = a / 16;
            }
            char[] stringarray = x.ToCharArray();
            Array.Reverse(stringarray);
            textBox2.Text = new string(stringarray);
        }

        private void BintoDec(int a)
        {
            double bin = 0;
            for (int i = 0; i < textBox1.TextLength; i++)
                if (textBox1.Text[i] == 49) bin += Math.Pow(2,textBox1.TextLength - (i + 1));
            textBox2.Text = bin.ToString();
        }
        private void BintoHex(int b)
        {
            double bin = 0;
            for (int i = 0; i < textBox1.TextLength; i++)
                if (textBox1.Text[i] == 49) bin += Math.Pow(2, textBox1.TextLength - (i + 1));
            int a = (int)bin;
            string x = "";
            while (a != 0)
            {
                int y = a % 16;
                if (y <= 9) x += y.ToString();
                else switch (y)
                    {
                        case 10: x += "A"; break;
                        case 11: x += "B"; break;
                        case 12: x += "C"; break;
                        case 13: x += "D"; break;
                        case 14: x += "E"; break;
                        case 15: x += "F"; break;
                    }
                a = a / 16;
            }
            char[] stringarray = x.ToCharArray();
            Array.Reverse(stringarray);
            textBox2.Text = new string(stringarray);
        }

        private void HextoDec(string str)
        {
            char[] x = str.ToCharArray();
            double a = 0;
            for (int i = 0;i < str.Length;i++)
            {
                if (x[i] <= 57 && x[i] >= 48)
                {
                    
                    a += (x[i] - '0')*Math.Pow(16, x.Length - ( i + 1 ));
                }
                    
                if (x[i] <= 70 && x[i] >= 65)
                {
                   
                    if (x[i] == 65) a += 10 * Math.Pow(16, x.Length - (i + 1));
                    if (x[i] == 66) a += 11 * Math.Pow(16, x.Length - (i + 1));
                    if (x[i] == 67) a += 12 * Math.Pow(16, x.Length - (i + 1));
                    if (x[i] == 68) a += 13 * Math.Pow(16, x.Length - (i + 1));
                    if (x[i] == 69) a += 14 * Math.Pow(16, x.Length - (i + 1));
                    if (x[i] == 70) a += 15 * Math.Pow(16, x.Length - (i + 1));
                }

            }
            textBox2.Text = a.ToString();
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
