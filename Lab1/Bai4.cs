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
                char[] x = textBox1.Text.ToCharArray();
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (x[i].Equals("A") == true || x[i].Equals("B") == true || x[i].Equals("C") == true || x[i].Equals("D") == true ||
                        x[i].Equals("F") == true || x[i].Equals("E") == true)
                    {
                    MessageBox.Show("ok");
                    }  
                }
            }
            
            else 
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
               //else if (comboBox1.Text == "Binary")
               // {
                    //if (comboBox2.Text == "Decimal") BintoDec(num1);
                   // else if (comboBox2.Text == "Hexadecimal") DectoHex(num1);
                    //else textBox2.Text = textBox1.Text;
                //}
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
