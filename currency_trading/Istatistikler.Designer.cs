
namespace _202503077
{
    partial class Istatistikler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Istatistikler));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.islemgüncelle_btn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kasaguncelle_btn = new System.Windows.Forms.Button();
            this.soyad_lbl = new System.Windows.Forms.Label();
            this.ad_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.para_dtg = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sonislem_dtg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.para_dtg)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sonislem_dtg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.groupBox1.Controls.Add(this.islemgüncelle_btn);
            this.groupBox1.Controls.Add(this.kasaguncelle_btn);
            this.groupBox1.Controls.Add(this.soyad_lbl);
            this.groupBox1.Controls.Add(this.ad_lbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // islemgüncelle_btn
            // 
            this.islemgüncelle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.islemgüncelle_btn.FlatAppearance.BorderSize = 0;
            this.islemgüncelle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemgüncelle_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.islemgüncelle_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.islemgüncelle_btn.ImageKey = "reloading.png";
            this.islemgüncelle_btn.ImageList = this.ımageList1;
            this.islemgüncelle_btn.Location = new System.Drawing.Point(606, 20);
            this.islemgüncelle_btn.Name = "islemgüncelle_btn";
            this.islemgüncelle_btn.Size = new System.Drawing.Size(220, 34);
            this.islemgüncelle_btn.TabIndex = 7;
            this.islemgüncelle_btn.Text = "     İşlemler Güncelle";
            this.islemgüncelle_btn.UseVisualStyleBackColor = false;
            this.islemgüncelle_btn.Click += new System.EventHandler(this.islemgüncelle_btn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "reloading.png");
            // 
            // kasaguncelle_btn
            // 
            this.kasaguncelle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.kasaguncelle_btn.FlatAppearance.BorderSize = 0;
            this.kasaguncelle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kasaguncelle_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.kasaguncelle_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kasaguncelle_btn.ImageKey = "reloading.png";
            this.kasaguncelle_btn.ImageList = this.ımageList1;
            this.kasaguncelle_btn.Location = new System.Drawing.Point(400, 20);
            this.kasaguncelle_btn.Name = "kasaguncelle_btn";
            this.kasaguncelle_btn.Size = new System.Drawing.Size(200, 34);
            this.kasaguncelle_btn.TabIndex = 6;
            this.kasaguncelle_btn.Text = "       Kasa Güncelle";
            this.kasaguncelle_btn.UseVisualStyleBackColor = false;
            this.kasaguncelle_btn.Click += new System.EventHandler(this.kasaguncelle_btn_Click);
            // 
            // soyad_lbl
            // 
            this.soyad_lbl.AutoSize = true;
            this.soyad_lbl.Location = new System.Drawing.Point(312, 33);
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
            this.label2.Location = new System.Drawing.Point(236, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.groupBox3.Controls.Add(this.para_dtg);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.groupBox3.Location = new System.Drawing.Point(18, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(832, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasadaki Para:";
            // 
            // para_dtg
            // 
            this.para_dtg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.para_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.para_dtg.DefaultCellStyle = dataGridViewCellStyle1;
            this.para_dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.para_dtg.Location = new System.Drawing.Point(3, 26);
            this.para_dtg.Name = "para_dtg";
            this.para_dtg.RowHeadersWidth = 51;
            this.para_dtg.Size = new System.Drawing.Size(826, 155);
            this.para_dtg.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.groupBox4.Controls.Add(this.sonislem_dtg);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.groupBox4.Location = new System.Drawing.Point(18, 286);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(832, 188);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kullanıcı Son İşlemleri";
            // 
            // sonislem_dtg
            // 
            this.sonislem_dtg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sonislem_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sonislem_dtg.DefaultCellStyle = dataGridViewCellStyle2;
            this.sonislem_dtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sonislem_dtg.Location = new System.Drawing.Point(3, 26);
            this.sonislem_dtg.Name = "sonislem_dtg";
            this.sonislem_dtg.RowHeadersWidth = 51;
            this.sonislem_dtg.Size = new System.Drawing.Size(826, 159);
            this.sonislem_dtg.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 496);
            this.panel1.TabIndex = 3;
            // 
            // Istatistikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(862, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Istatistikler";
            this.Text = "Istatistikler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.para_dtg)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sonislem_dtg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label soyad_lbl;
        private System.Windows.Forms.Label ad_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView para_dtg;
        private System.Windows.Forms.DataGridView sonislem_dtg;
        private System.Windows.Forms.Button islemgüncelle_btn;
        private System.Windows.Forms.Button kasaguncelle_btn;
    }
}