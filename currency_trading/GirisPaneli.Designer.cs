
namespace _202503077
{
    partial class GirisPaneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisPaneli));
            this.kadi_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.giris_btn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kadi_txt
            // 
            this.kadi_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.kadi_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kadi_txt.Font = new System.Drawing.Font("Branding SF Narrow Bold", 18F, System.Drawing.FontStyle.Bold);
            this.kadi_txt.ForeColor = System.Drawing.Color.White;
            this.kadi_txt.Location = new System.Drawing.Point(90, 129);
            this.kadi_txt.Margin = new System.Windows.Forms.Padding(4);
            this.kadi_txt.Multiline = true;
            this.kadi_txt.Name = "kadi_txt";
            this.kadi_txt.Size = new System.Drawing.Size(230, 35);
            this.kadi_txt.TabIndex = 0;
            // 
            // sifre_txt
            // 
            this.sifre_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sifre_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifre_txt.Font = new System.Drawing.Font("Branding SF Narrow Bold", 18F, System.Drawing.FontStyle.Bold);
            this.sifre_txt.ForeColor = System.Drawing.Color.White;
            this.sifre_txt.Location = new System.Drawing.Point(90, 195);
            this.sifre_txt.Margin = new System.Windows.Forms.Padding(4);
            this.sifre_txt.Multiline = true;
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.PasswordChar = '*';
            this.sifre_txt.Size = new System.Drawing.Size(230, 35);
            this.sifre_txt.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // giris_btn
            // 
            this.giris_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.giris_btn.FlatAppearance.BorderSize = 0;
            this.giris_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.giris_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.giris_btn.ImageKey = "user-login.png";
            this.giris_btn.ImageList = this.ımageList1;
            this.giris_btn.Location = new System.Drawing.Point(77, 266);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(200, 52);
            this.giris_btn.TabIndex = 4;
            this.giris_btn.Text = "Giriş Yap";
            this.giris_btn.UseVisualStyleBackColor = false;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "user-login.png");
            // 
            // GirisPaneli
            // 
            this.AcceptButton = this.giris_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(356, 381);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.kadi_txt);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Paneli";
            this.Load += new System.EventHandler(this.GirisPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kadi_txt;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

