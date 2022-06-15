
namespace _202503077
{
    partial class Duyurular
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Duyurular));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.duyuruGuncelle_btn = new System.Windows.Forms.Button();
            this.duyuruKaldir_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.duyuru_rchtbox = new System.Windows.Forms.RichTextBox();
            this.dyrBslk_txt = new System.Windows.Forms.TextBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.adsoyad_lbl = new System.Windows.Forms.Label();
            this.temizle_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "eraser.png");
            this.ımageList1.Images.SetKeyName(1, "megaphone.png");
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geçmiş Duyurular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(831, 163);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // duyuruGuncelle_btn
            // 
            this.duyuruGuncelle_btn.AutoSize = true;
            this.duyuruGuncelle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.duyuruGuncelle_btn.FlatAppearance.BorderSize = 0;
            this.duyuruGuncelle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duyuruGuncelle_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.duyuruGuncelle_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duyuruGuncelle_btn.ImageKey = "megaphone.png";
            this.duyuruGuncelle_btn.ImageList = this.ımageList1;
            this.duyuruGuncelle_btn.Location = new System.Drawing.Point(566, 520);
            this.duyuruGuncelle_btn.Name = "duyuruGuncelle_btn";
            this.duyuruGuncelle_btn.Size = new System.Drawing.Size(276, 38);
            this.duyuruGuncelle_btn.TabIndex = 7;
            this.duyuruGuncelle_btn.Text = "Duyuruları Güncelle";
            this.duyuruGuncelle_btn.UseVisualStyleBackColor = false;
            this.duyuruGuncelle_btn.Click += new System.EventHandler(this.duyuruGuncelle_btn_Click);
            // 
            // duyuruKaldir_btn
            // 
            this.duyuruKaldir_btn.AutoSize = true;
            this.duyuruKaldir_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.duyuruKaldir_btn.FlatAppearance.BorderSize = 0;
            this.duyuruKaldir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duyuruKaldir_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.duyuruKaldir_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duyuruKaldir_btn.ImageKey = "eraser.png";
            this.duyuruKaldir_btn.ImageList = this.ımageList1;
            this.duyuruKaldir_btn.Location = new System.Drawing.Point(318, 520);
            this.duyuruKaldir_btn.Name = "duyuruKaldir_btn";
            this.duyuruKaldir_btn.Size = new System.Drawing.Size(242, 38);
            this.duyuruKaldir_btn.TabIndex = 8;
            this.duyuruKaldir_btn.Text = "Duyuruyu Kaldır";
            this.duyuruKaldir_btn.UseVisualStyleBackColor = false;
            this.duyuruKaldir_btn.Click += new System.EventHandler(this.duyuruKaldir_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.duyuru_rchtbox);
            this.groupBox3.Controls.Add(this.dyrBslk_txt);
            this.groupBox3.Controls.Add(this.ekle_btn);
            this.groupBox3.Controls.Add(this.adsoyad_lbl);
            this.groupBox3.Controls.Add(this.temizle_btn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.groupBox3.Location = new System.Drawing.Point(15, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(834, 295);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duyuru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Duyuru Başlık:";
            // 
            // duyuru_rchtbox
            // 
            this.duyuru_rchtbox.Location = new System.Drawing.Point(17, 67);
            this.duyuru_rchtbox.Name = "duyuru_rchtbox";
            this.duyuru_rchtbox.Size = new System.Drawing.Size(797, 148);
            this.duyuru_rchtbox.TabIndex = 0;
            this.duyuru_rchtbox.Text = "";
            // 
            // dyrBslk_txt
            // 
            this.dyrBslk_txt.Location = new System.Drawing.Point(193, 23);
            this.dyrBslk_txt.Name = "dyrBslk_txt";
            this.dyrBslk_txt.Size = new System.Drawing.Size(173, 30);
            this.dyrBslk_txt.TabIndex = 5;
            // 
            // ekle_btn
            // 
            this.ekle_btn.AutoSize = true;
            this.ekle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ekle_btn.FlatAppearance.BorderSize = 0;
            this.ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.ekle_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekle_btn.ImageKey = "megaphone.png";
            this.ekle_btn.ImageList = this.ımageList1;
            this.ekle_btn.Location = new System.Drawing.Point(572, 228);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(242, 38);
            this.ekle_btn.TabIndex = 1;
            this.ekle_btn.Text = "Duyuruyu Ekle";
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // adsoyad_lbl
            // 
            this.adsoyad_lbl.AutoSize = true;
            this.adsoyad_lbl.Location = new System.Drawing.Point(641, 26);
            this.adsoyad_lbl.Name = "adsoyad_lbl";
            this.adsoyad_lbl.Size = new System.Drawing.Size(45, 24);
            this.adsoyad_lbl.TabIndex = 4;
            this.adsoyad_lbl.Text = "-----";
            // 
            // temizle_btn
            // 
            this.temizle_btn.AutoSize = true;
            this.temizle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.temizle_btn.FlatAppearance.BorderSize = 0;
            this.temizle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temizle_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.temizle_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.temizle_btn.ImageKey = "eraser.png";
            this.temizle_btn.ImageList = this.ımageList1;
            this.temizle_btn.Location = new System.Drawing.Point(393, 228);
            this.temizle_btn.Name = "temizle_btn";
            this.temizle_btn.Size = new System.Drawing.Size(175, 38);
            this.temizle_btn.TabIndex = 2;
            this.temizle_btn.Text = "Temizle";
            this.temizle_btn.UseVisualStyleBackColor = false;
            this.temizle_btn.Click += new System.EventHandler(this.temizle_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gönderen:";
            // 
            // Duyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(866, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.duyuruKaldir_btn);
            this.Controls.Add(this.duyuruGuncelle_btn);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Duyurular";
            this.Text = "Duyurular";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button duyuruGuncelle_btn;
        private System.Windows.Forms.Button duyuruKaldir_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox duyuru_rchtbox;
        private System.Windows.Forms.TextBox dyrBslk_txt;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Label adsoyad_lbl;
        private System.Windows.Forms.Button temizle_btn;
        private System.Windows.Forms.Label label1;
    }
}