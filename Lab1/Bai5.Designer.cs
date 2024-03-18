namespace Lab1
{
    partial class Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreList = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.GroupBox();
            this.Outputlist = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AvgScore = new System.Windows.Forms.Label();
            this.HighestScore = new System.Windows.Forms.Label();
            this.PassedSubj = new System.Windows.Forms.Label();
            this.Rank = new System.Windows.Forms.Label();
            this.LowestScore = new System.Windows.Forms.Label();
            this.FailedSubj = new System.Windows.Forms.Label();
            this.Xuat = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(280, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lý điểm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách điểm: ";
            // 
            // ScoreList
            // 
            this.ScoreList.Location = new System.Drawing.Point(223, 75);
            this.ScoreList.Name = "ScoreList";
            this.ScoreList.Size = new System.Drawing.Size(484, 22);
            this.ScoreList.TabIndex = 2;
            // 
            // Output
            // 
            this.Output.Controls.Add(this.Outputlist);
            this.Output.Location = new System.Drawing.Point(110, 136);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(597, 160);
            this.Output.TabIndex = 3;
            this.Output.TabStop = false;
            this.Output.Text = "Danh sách môn học và điểm";
            // 
            // Outputlist
            // 
            this.Outputlist.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Outputlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Outputlist.Location = new System.Drawing.Point(22, 21);
            this.Outputlist.Name = "Outputlist";
            this.Outputlist.Size = new System.Drawing.Size(554, 121);
            this.Outputlist.TabIndex = 0;
            this.Outputlist.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm trung bình: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Môn có điểm cao nhất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số môn đậu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số môn không đậu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Môn có điểm thấp nhất: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Xếp loại học lực:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 11;
            // 
            // AvgScore
            // 
            this.AvgScore.AutoSize = true;
            this.AvgScore.Location = new System.Drawing.Point(217, 319);
            this.AvgScore.Name = "AvgScore";
            this.AvgScore.Size = new System.Drawing.Size(0, 16);
            this.AvgScore.TabIndex = 12;
            // 
            // HighestScore
            // 
            this.HighestScore.AutoSize = true;
            this.HighestScore.Location = new System.Drawing.Point(254, 363);
            this.HighestScore.Name = "HighestScore";
            this.HighestScore.Size = new System.Drawing.Size(0, 16);
            this.HighestScore.TabIndex = 13;
            // 
            // PassedSubj
            // 
            this.PassedSubj.AutoSize = true;
            this.PassedSubj.Location = new System.Drawing.Point(195, 408);
            this.PassedSubj.Name = "PassedSubj";
            this.PassedSubj.Size = new System.Drawing.Size(0, 16);
            this.PassedSubj.TabIndex = 14;
            // 
            // Rank
            // 
            this.Rank.AutoSize = true;
            this.Rank.Location = new System.Drawing.Point(559, 319);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(0, 16);
            this.Rank.TabIndex = 15;
            // 
            // LowestScore
            // 
            this.LowestScore.AutoSize = true;
            this.LowestScore.Location = new System.Drawing.Point(602, 363);
            this.LowestScore.Name = "LowestScore";
            this.LowestScore.Size = new System.Drawing.Size(0, 16);
            this.LowestScore.TabIndex = 16;
            // 
            // FailedSubj
            // 
            this.FailedSubj.AutoSize = true;
            this.FailedSubj.Location = new System.Drawing.Point(577, 408);
            this.FailedSubj.Name = "FailedSubj";
            this.FailedSubj.Size = new System.Drawing.Size(0, 16);
            this.FailedSubj.TabIndex = 17;
            // 
            // Xuat
            // 
            this.Xuat.Location = new System.Drawing.Point(403, 103);
            this.Xuat.Name = "Xuat";
            this.Xuat.Size = new System.Drawing.Size(94, 34);
            this.Xuat.TabIndex = 18;
            this.Xuat.Text = "Xuất";
            this.Xuat.UseVisualStyleBackColor = true;
            this.Xuat.Click += new System.EventHandler(this.Xuat_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(508, 103);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(94, 34);
            this.Xoa.TabIndex = 19;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(613, 103);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(94, 34);
            this.Thoat.TabIndex = 1;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Xuat);
            this.Controls.Add(this.FailedSubj);
            this.Controls.Add(this.LowestScore);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.PassedSubj);
            this.Controls.Add(this.HighestScore);
            this.Controls.Add(this.AvgScore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.ScoreList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.Output.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ScoreList;
        private System.Windows.Forms.GroupBox Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label AvgScore;
        private System.Windows.Forms.Label HighestScore;
        private System.Windows.Forms.Label PassedSubj;
        private System.Windows.Forms.Label Rank;
        private System.Windows.Forms.Label LowestScore;
        private System.Windows.Forms.Label FailedSubj;
        private System.Windows.Forms.Button Xuat;
        private System.Windows.Forms.RichTextBox Outputlist;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
    }
}