
namespace _202503077
{
    partial class GecmisIslemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GecmisIslemler));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.soyad_lbl = new System.Windows.Forms.Label();
            this.ad_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tlistele_btn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.calisanlar_cmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.İşlemler = new System.Windows.Forms.GroupBox();
            this.islemler_dtg = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listele2_btn = new System.Windows.Forms.Button();
            this.siralama_cmb = new System.Windows.Forms.ComboBox();
            this.bitis_lbl = new System.Windows.Forms.Label();
            this.bitis_dtp = new System.Windows.Forms.DateTimePicker();
            this.baslangic_lbl = new System.Windows.Forms.Label();
            this.baslangic_dtp = new System.Windows.Forms.DateTimePicker();
            this.listele_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rapor_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.İşlemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islemler_dtg)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.soyad_lbl);
            this.groupBox1.Controls.Add(this.ad_lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // soyad_lbl
            // 
            this.soyad_lbl.AutoSize = true;
            this.soyad_lbl.Location = new System.Drawing.Point(85, 65);
            this.soyad_lbl.Name = "soyad_lbl";
            this.soyad_lbl.Size = new System.Drawing.Size(45, 24);
            this.soyad_lbl.TabIndex = 3;
            this.soyad_lbl.Text = "-----";
            // 
            // ad_lbl
            // 
            this.ad_lbl.AutoSize = true;
            this.ad_lbl.Location = new System.Drawing.Point(85, 33);
            this.ad_lbl.Name = "ad_lbl";
            this.ad_lbl.Size = new System.Drawing.Size(45, 24);
            this.ad_lbl.TabIndex = 2;
            this.ad_lbl.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // tlistele_btn
            // 
            this.tlistele_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tlistele_btn.FlatAppearance.BorderSize = 0;
            this.tlistele_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tlistele_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.tlistele_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlistele_btn.ImageKey = "bullet-list.png";
            this.tlistele_btn.ImageList = this.ımageList1;
            this.tlistele_btn.Location = new System.Drawing.Point(253, 74);
            this.tlistele_btn.Name = "tlistele_btn";
            this.tlistele_btn.Size = new System.Drawing.Size(194, 34);
            this.tlistele_btn.TabIndex = 6;
            this.tlistele_btn.Text = "T. Listele";
            this.tlistele_btn.UseVisualStyleBackColor = false;
            this.tlistele_btn.Click += new System.EventHandler(this.tlistele_btn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "bullet-list.png");
            // 
            // calisanlar_cmb
            // 
            this.calisanlar_cmb.FormattingEnabled = true;
            this.calisanlar_cmb.Location = new System.Drawing.Point(212, 32);
            this.calisanlar_cmb.Name = "calisanlar_cmb";
            this.calisanlar_cmb.Size = new System.Drawing.Size(158, 32);
            this.calisanlar_cmb.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.label8.Location = new System.Drawing.Point(102, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ad Soyad:";
            // 
            // İşlemler
            // 
            this.İşlemler.Controls.Add(this.islemler_dtg);
            this.İşlemler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.İşlemler.Location = new System.Drawing.Point(12, 246);
            this.İşlemler.Name = "İşlemler";
            this.İşlemler.Size = new System.Drawing.Size(840, 256);
            this.İşlemler.TabIndex = 4;
            this.İşlemler.TabStop = false;
            this.İşlemler.Text = "Kullanıcı Bilgileri";
            // 
            // islemler_dtg
            // 
            this.islemler_dtg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.islemler_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.islemler_dtg.DefaultCellStyle = dataGridViewCellStyle1;
            this.islemler_dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.islemler_dtg.Location = new System.Drawing.Point(3, 26);
            this.islemler_dtg.Name = "islemler_dtg";
            this.islemler_dtg.RowHeadersWidth = 51;
            this.islemler_dtg.Size = new System.Drawing.Size(834, 227);
            this.islemler_dtg.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listele2_btn);
            this.groupBox4.Controls.Add(this.siralama_cmb);
            this.groupBox4.Controls.Add(this.bitis_lbl);
            this.groupBox4.Controls.Add(this.bitis_dtp);
            this.groupBox4.Controls.Add(this.baslangic_lbl);
            this.groupBox4.Controls.Add(this.baslangic_dtp);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.groupBox4.Location = new System.Drawing.Point(12, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(840, 96);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama Filtresi";
            // 
            // listele2_btn
            // 
            this.listele2_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.listele2_btn.FlatAppearance.BorderSize = 0;
            this.listele2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listele2_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.listele2_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listele2_btn.ImageKey = "bullet-list.png";
            this.listele2_btn.ImageList = this.ımageList1;
            this.listele2_btn.Location = new System.Drawing.Point(619, 35);
            this.listele2_btn.Name = "listele2_btn";
            this.listele2_btn.Size = new System.Drawing.Size(180, 34);
            this.listele2_btn.TabIndex = 7;
            this.listele2_btn.Text = "Listele";
            this.listele2_btn.UseVisualStyleBackColor = false;
            this.listele2_btn.Click += new System.EventHandler(this.listele2_btn_Click);
            // 
            // siralama_cmb
            // 
            this.siralama_cmb.FormattingEnabled = true;
            this.siralama_cmb.Location = new System.Drawing.Point(24, 37);
            this.siralama_cmb.Name = "siralama_cmb";
            this.siralama_cmb.Size = new System.Drawing.Size(216, 32);
            this.siralama_cmb.TabIndex = 6;
            this.siralama_cmb.SelectedIndexChanged += new System.EventHandler(this.siralama_cmb_SelectedIndexChanged);
            // 
            // bitis_lbl
            // 
            this.bitis_lbl.AutoSize = true;
            this.bitis_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.bitis_lbl.Location = new System.Drawing.Point(321, 61);
            this.bitis_lbl.Name = "bitis_lbl";
            this.bitis_lbl.Size = new System.Drawing.Size(59, 24);
            this.bitis_lbl.TabIndex = 5;
            this.bitis_lbl.Text = "Bitiş:";
            // 
            // bitis_dtp
            // 
            this.bitis_dtp.Location = new System.Drawing.Point(382, 57);
            this.bitis_dtp.Name = "bitis_dtp";
            this.bitis_dtp.Size = new System.Drawing.Size(187, 30);
            this.bitis_dtp.TabIndex = 1;
            this.bitis_dtp.Value = new System.DateTime(2022, 5, 14, 0, 0, 0, 0);
            // 
            // baslangic_lbl
            // 
            this.baslangic_lbl.AutoSize = true;
            this.baslangic_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.baslangic_lbl.Location = new System.Drawing.Point(271, 23);
            this.baslangic_lbl.Name = "baslangic_lbl";
            this.baslangic_lbl.Size = new System.Drawing.Size(109, 24);
            this.baslangic_lbl.TabIndex = 4;
            this.baslangic_lbl.Text = "Başlangıç:";
            // 
            // baslangic_dtp
            // 
            this.baslangic_dtp.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.baslangic_dtp.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.baslangic_dtp.Location = new System.Drawing.Point(382, 19);
            this.baslangic_dtp.Name = "baslangic_dtp";
            this.baslangic_dtp.Size = new System.Drawing.Size(187, 30);
            this.baslangic_dtp.TabIndex = 0;
            this.baslangic_dtp.Value = new System.DateTime(2022, 5, 14, 0, 0, 0, 0);
            // 
            // listele_btn
            // 
            this.listele_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.listele_btn.FlatAppearance.BorderSize = 0;
            this.listele_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listele_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.listele_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listele_btn.ImageKey = "bullet-list.png";
            this.listele_btn.ImageList = this.ımageList1;
            this.listele_btn.Location = new System.Drawing.Point(67, 74);
            this.listele_btn.Name = "listele_btn";
            this.listele_btn.Size = new System.Drawing.Size(180, 34);
            this.listele_btn.TabIndex = 5;
            this.listele_btn.Text = "Listele";
            this.listele_btn.UseVisualStyleBackColor = false;
            this.listele_btn.Click += new System.EventHandler(this.listele_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tlistele_btn);
            this.groupBox2.Controls.Add(this.listele_btn);
            this.groupBox2.Controls.Add(this.calisanlar_cmb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.groupBox2.Location = new System.Drawing.Point(345, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.label3.Location = new System.Drawing.Point(21, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(835, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dikkat: İstenilen Kullanıcı \'Kullanıcı Bilgilerinde\' Seçildikten Sonra Filtre Yin" +
    "e Eklenebilir ";
            // 
            // rapor_btn
            // 
            this.rapor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.rapor_btn.FlatAppearance.BorderSize = 0;
            this.rapor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rapor_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.rapor_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rapor_btn.ImageKey = "bullet-list.png";
            this.rapor_btn.ImageList = this.ımageList1;
            this.rapor_btn.Location = new System.Drawing.Point(618, 548);
            this.rapor_btn.Name = "rapor_btn";
            this.rapor_btn.Size = new System.Drawing.Size(231, 34);
            this.rapor_btn.TabIndex = 8;
            this.rapor_btn.Text = "    Rapor Oluştur";
            this.rapor_btn.UseVisualStyleBackColor = false;
            this.rapor_btn.Click += new System.EventHandler(this.rapor_btn_Click);
            // 
            // GecmisIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(864, 605);
            this.Controls.Add(this.rapor_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.İşlemler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GecmisIslemler";
            this.Text = "Gecmiş İşlemler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.İşlemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.islemler_dtg)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label soyad_lbl;
        private System.Windows.Forms.Label ad_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tlistele_btn;
        private System.Windows.Forms.ComboBox calisanlar_cmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox İşlemler;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker bitis_dtp;
        private System.Windows.Forms.DateTimePicker baslangic_dtp;
        private System.Windows.Forms.Button listele2_btn;
        private System.Windows.Forms.ComboBox siralama_cmb;
        private System.Windows.Forms.Label bitis_lbl;
        private System.Windows.Forms.Label baslangic_lbl;
        private System.Windows.Forms.DataGridView islemler_dtg;
        private System.Windows.Forms.Button listele_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rapor_btn;
    }
}