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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Xuat_Click(object sender, EventArgs e)
        {
            Outputlist.Clear();
            string[] score = ScoreList.Text.Split(' ');
            List<float> numscore = new List<float>();
            foreach (string s in score)
            {
                float numtest;
                if (!(float.TryParse(s, out numtest))) 
                {
                    MessageBox.Show("Vui lòng nhập đúng format");
                    return;
                }
                else
                {
                    if (numtest < 0 || numtest > 10)
                    {
                        MessageBox.Show("Điểm nằm trong đoạn [0;10]");
                        return;
                    }
                    else numscore.Add(numtest);
                }
            }
            float maxScore = numscore.Max();
            float minScore = numscore.Min();
            float avgScore = numscore.Average();
            decimal avgScoreOut = Math.Round((decimal)avgScore, 2);
            int passnum = 0, failnum = 0, g = 0, k = 0, tb = 0, y = 0;
            foreach (float f in  numscore)
            {
                if (f >= 5) passnum++;
                else failnum++;
                if (f < 2) y++;
                else if (f < 3.5) tb++;
                else if (f < 5) k++;
                else if (f < 6.5) g++;
            }
            for (int i = 0; i < numscore.Count; i++)
            {
                string s = "Môn " + (i+1).ToString() + ": " + numscore[i].ToString() + "đ";
                Outputlist.AppendText(s);
                Outputlist.AppendText("\t");
                if ((i + 1) % 4 == 0) Outputlist.AppendText("\n");
            }
            AvgScore.Text = avgScoreOut.ToString();
            HighestScore.Text = maxScore.ToString() + " đ";
            LowestScore.Text = minScore.ToString() + " đ";
            PassedSubj.Text = passnum.ToString();
            FailedSubj.Text = failnum.ToString();
            if (avgScore >= 8 && g == 0) Rank.Text = "Giỏi";
            else if (avgScore >= 6.5 && k == 0) Rank.Text = "Khá";
            else if (avgScore >= 5 && tb == 0) Rank.Text = "Trung bình";
            else if (avgScore >= 3.5 && y == 0) Rank.Text = "Yếu";
            else Rank.Text = "Kém";
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            ScoreList.Clear();
            Outputlist.Clear();
            AvgScore.ResetText();
            HighestScore.ResetText();
            LowestScore.ResetText();
            PassedSubj.ResetText(); 
            FailedSubj.ResetText();
            Rank.ResetText();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
