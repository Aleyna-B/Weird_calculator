namespace _22118080003
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonfakto = new System.Windows.Forms.Button();
            this.labelsayı = new System.Windows.Forms.Label();
            this.textBoxsayı = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.label_S = new System.Windows.Forms.Label();
            this.label_F = new System.Windows.Forms.Label();
            this.buttonasal = new System.Windows.Forms.Button();
            this.buttonkendisinekadar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonfakto
            // 
            this.buttonfakto.BackColor = System.Drawing.Color.Tomato;
            this.buttonfakto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonfakto.Location = new System.Drawing.Point(60, 134);
            this.buttonfakto.Name = "buttonfakto";
            this.buttonfakto.Size = new System.Drawing.Size(123, 31);
            this.buttonfakto.TabIndex = 0;
            this.buttonfakto.Text = "Faktöriyel";
            this.buttonfakto.UseVisualStyleBackColor = false;
            this.buttonfakto.Click += new System.EventHandler(this.buttonfakto_Click);
            // 
            // labelsayı
            // 
            this.labelsayı.AutoSize = true;
            this.labelsayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsayı.Location = new System.Drawing.Point(81, 49);
            this.labelsayı.Name = "labelsayı";
            this.labelsayı.Size = new System.Drawing.Size(102, 24);
            this.labelsayı.TabIndex = 1;
            this.labelsayı.Text = "Sayı Giriniz";
            // 
            // textBoxsayı
            // 
            this.textBoxsayı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxsayı.Location = new System.Drawing.Point(309, 49);
            this.textBoxsayı.Multiline = true;
            this.textBoxsayı.Name = "textBoxsayı";
            this.textBoxsayı.Size = new System.Drawing.Size(127, 30);
            this.textBoxsayı.TabIndex = 2;
            this.textBoxsayı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_A.Location = new System.Drawing.Point(322, 221);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(0, 24);
            this.label_A.TabIndex = 3;
            // 
            // label_S
            // 
            this.label_S.AutoSize = true;
            this.label_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_S.Location = new System.Drawing.Point(322, 329);
            this.label_S.Name = "label_S";
            this.label_S.Size = new System.Drawing.Size(0, 24);
            this.label_S.TabIndex = 4;
            this.label_S.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_F
            // 
            this.label_F.AutoSize = true;
            this.label_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_F.Location = new System.Drawing.Point(322, 134);
            this.label_F.Name = "label_F";
            this.label_F.Size = new System.Drawing.Size(0, 24);
            this.label_F.TabIndex = 5;
            // 
            // buttonasal
            // 
            this.buttonasal.BackColor = System.Drawing.Color.Tomato;
            this.buttonasal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonasal.Location = new System.Drawing.Point(60, 221);
            this.buttonasal.Name = "buttonasal";
            this.buttonasal.Size = new System.Drawing.Size(123, 31);
            this.buttonasal.TabIndex = 6;
            this.buttonasal.Text = "Asal sayı mı?";
            this.buttonasal.UseVisualStyleBackColor = false;
            this.buttonasal.Click += new System.EventHandler(this.buttonasal_Click);
            // 
            // buttonkendisinekadar
            // 
            this.buttonkendisinekadar.BackColor = System.Drawing.Color.Tomato;
            this.buttonkendisinekadar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonkendisinekadar.Location = new System.Drawing.Point(60, 306);
            this.buttonkendisinekadar.Name = "buttonkendisinekadar";
            this.buttonkendisinekadar.Size = new System.Drawing.Size(123, 73);
            this.buttonkendisinekadar.TabIndex = 7;
            this.buttonkendisinekadar.Text = "Kendisine Kadar Olan Pozitif Sayılar";
            this.buttonkendisinekadar.UseVisualStyleBackColor = false;
            this.buttonkendisinekadar.Click += new System.EventHandler(this.buttonkendisinekadar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(534, 407);
            this.Controls.Add(this.buttonkendisinekadar);
            this.Controls.Add(this.buttonasal);
            this.Controls.Add(this.label_F);
            this.Controls.Add(this.label_S);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.textBoxsayı);
            this.Controls.Add(this.labelsayı);
            this.Controls.Add(this.buttonfakto);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BM102 Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonfakto;
        private System.Windows.Forms.Label labelsayı;
        private System.Windows.Forms.TextBox textBoxsayı;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_S;
        private System.Windows.Forms.Label label_F;
        private System.Windows.Forms.Button buttonasal;
        private System.Windows.Forms.Button buttonkendisinekadar;
    }
}

