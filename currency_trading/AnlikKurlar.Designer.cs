
namespace _202503077
{
    partial class AnlikKurlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnlikKurlar));
            this.yenile_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xmldtg = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xmldtg)).BeginInit();
            this.SuspendLayout();
            // 
            // yenile_btn
            // 
            this.yenile_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.yenile_btn.FlatAppearance.BorderSize = 0;
            this.yenile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenile_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.yenile_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yenile_btn.ImageKey = "reloading.png";
            this.yenile_btn.ImageList = this.ımageList1;
            this.yenile_btn.Location = new System.Drawing.Point(642, 473);
            this.yenile_btn.Name = "yenile_btn";
            this.yenile_btn.Size = new System.Drawing.Size(177, 34);
            this.yenile_btn.TabIndex = 66;
            this.yenile_btn.Text = "Yenile";
            this.yenile_btn.UseVisualStyleBackColor = false;
            this.yenile_btn.Click += new System.EventHandler(this.yenile_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xmldtg);
            this.groupBox1.Controls.Add(this.yenile_btn);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 520);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anlık kurlar";
            // 
            // xmldtg
            // 
            this.xmldtg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.xmldtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(4)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.xmldtg.DefaultCellStyle = dataGridViewCellStyle1;
            this.xmldtg.Dock = System.Windows.Forms.DockStyle.Top;
            this.xmldtg.Location = new System.Drawing.Point(3, 26);
            this.xmldtg.Name = "xmldtg";
            this.xmldtg.RowHeadersWidth = 51;
            this.xmldtg.Size = new System.Drawing.Size(830, 432);
            this.xmldtg.TabIndex = 67;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "reloading.png");
            // 
            // AnlikKurlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(864, 553);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnlikKurlar";
            this.Text = "AnlikKurlar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xmldtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yenile_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView xmldtg;
        private System.Windows.Forms.ImageList ımageList1;
    }
}