namespace VeriYapilari_Odev7
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSayiBul = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnTraverseLevel = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btn_TraversePre = new System.Windows.Forms.Button();
            this.btnTraversePost = new System.Windows.Forms.Button();
            this.btnTraverseIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(531, 47);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(128, 31);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(389, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(389, 258);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 23);
            this.textBox2.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(531, 258);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(128, 31);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(16, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 463);
            this.listBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sonuç:";
            // 
            // btnSayiBul
            // 
            this.btnSayiBul.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSayiBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSayiBul.Location = new System.Drawing.Point(531, 306);
            this.btnSayiBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnSayiBul.Name = "btnSayiBul";
            this.btnSayiBul.Size = new System.Drawing.Size(128, 31);
            this.btnSayiBul.TabIndex = 12;
            this.btnSayiBul.Text = "Sayı Bul";
            this.btnSayiBul.UseVisualStyleBackColor = false;
            this.btnSayiBul.Click += new System.EventHandler(this.btnSayiBul_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Max.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Max.Location = new System.Drawing.Point(486, 390);
            this.btn_Max.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(128, 31);
            this.btn_Max.TabIndex = 14;
            this.btn_Max.Text = "Maximum Bul";
            this.btn_Max.UseVisualStyleBackColor = false;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "__";
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMin.Location = new System.Drawing.Point(486, 442);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(128, 31);
            this.btnMin.TabIndex = 16;
            this.btnMin.Text = "Minimum Bul";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "__";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(389, 306);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 23);
            this.textBox3.TabIndex = 17;
            // 
            // btnTraverseLevel
            // 
            this.btnTraverseLevel.BackColor = System.Drawing.Color.PowderBlue;
            this.btnTraverseLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraverseLevel.Location = new System.Drawing.Point(367, 98);
            this.btnTraverseLevel.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraverseLevel.Name = "btnTraverseLevel";
            this.btnTraverseLevel.Size = new System.Drawing.Size(128, 35);
            this.btnTraverseLevel.TabIndex = 18;
            this.btnTraverseLevel.Text = "Level Order";
            this.btnTraverseLevel.UseVisualStyleBackColor = false;
            this.btnTraverseLevel.Click += new System.EventHandler(this.btnTraverse_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.BackColor = System.Drawing.Color.PowderBlue;
            this.btnHepsiniSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHepsiniSil.Location = new System.Drawing.Point(367, 206);
            this.btnHepsiniSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(292, 36);
            this.btnHepsiniSil.TabIndex = 19;
            this.btnHepsiniSil.Text = "Hepsini Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = false;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btn_TraversePre
            // 
            this.btn_TraversePre.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_TraversePre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TraversePre.Location = new System.Drawing.Point(531, 98);
            this.btn_TraversePre.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TraversePre.Name = "btn_TraversePre";
            this.btn_TraversePre.Size = new System.Drawing.Size(128, 35);
            this.btn_TraversePre.TabIndex = 21;
            this.btn_TraversePre.Text = "Pre Order";
            this.btn_TraversePre.UseVisualStyleBackColor = false;
            this.btn_TraversePre.Click += new System.EventHandler(this.btn_TraversePre_Click);
            // 
            // btnTraversePost
            // 
            this.btnTraversePost.BackColor = System.Drawing.Color.PowderBlue;
            this.btnTraversePost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraversePost.Location = new System.Drawing.Point(367, 154);
            this.btnTraversePost.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraversePost.Name = "btnTraversePost";
            this.btnTraversePost.Size = new System.Drawing.Size(128, 35);
            this.btnTraversePost.TabIndex = 22;
            this.btnTraversePost.Text = "Post Order";
            this.btnTraversePost.UseVisualStyleBackColor = false;
            this.btnTraversePost.Click += new System.EventHandler(this.btnTraversePost_Click);
            // 
            // btnTraverseIn
            // 
            this.btnTraverseIn.BackColor = System.Drawing.Color.PowderBlue;
            this.btnTraverseIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraverseIn.Location = new System.Drawing.Point(531, 154);
            this.btnTraverseIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraverseIn.Name = "btnTraverseIn";
            this.btnTraverseIn.Size = new System.Drawing.Size(128, 35);
            this.btnTraverseIn.TabIndex = 23;
            this.btnTraverseIn.Text = "In Order";
            this.btnTraverseIn.UseVisualStyleBackColor = false;
            this.btnTraverseIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 492);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cansu AYTEN 171180010";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(676, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTraverseIn);
            this.Controls.Add(this.btnTraversePost);
            this.Controls.Add(this.btn_TraversePre);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.btnTraverseLevel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Max);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSayiBul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Search Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSayiBul;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnTraverseLevel;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btn_TraversePre;
        private System.Windows.Forms.Button btnTraversePost;
        private System.Windows.Forms.Button btnTraverseIn;
        private System.Windows.Forms.Label label3;
    }
}

