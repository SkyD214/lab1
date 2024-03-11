namespace Lab1
{
    partial class Bai3
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
            this.SoNguyen = new System.Windows.Forms.TextBox();
            this.Ketqua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.doc = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Vào Số Nguyên";
            // 
            // SoNguyen
            // 
            this.SoNguyen.Location = new System.Drawing.Point(223, 67);
            this.SoNguyen.Name = "SoNguyen";
            this.SoNguyen.Size = new System.Drawing.Size(211, 22);
            this.SoNguyen.TabIndex = 1;
            // 
            // Ketqua
            // 
            this.Ketqua.Location = new System.Drawing.Point(82, 177);
            this.Ketqua.Name = "Ketqua";
            this.Ketqua.ReadOnly = true;
            this.Ketqua.Size = new System.Drawing.Size(352, 22);
            this.Ketqua.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết Quả";
            // 
            // doc
            // 
            this.doc.Location = new System.Drawing.Point(545, 62);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(100, 40);
            this.doc.TabIndex = 4;
            this.doc.Text = "Đọc";
            this.doc.UseVisualStyleBackColor = true;
            this.doc.Click += new System.EventHandler(this.doc_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(545, 152);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(100, 40);
            this.xoa.TabIndex = 5;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(545, 240);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(100, 40);
            this.thoat.TabIndex = 6;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.doc);
            this.Controls.Add(this.Ketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SoNguyen);
            this.Controls.Add(this.label1);
            this.Name = "Bai3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SoNguyen;
        private System.Windows.Forms.TextBox Ketqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button doc;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
    }
}