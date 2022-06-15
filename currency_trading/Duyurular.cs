using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202503077
{
    public partial class Duyurular : Form
    {

        string sorgu = "select duyuruyu_yapan,duyuru_ismi,duyuru,duyuru_tarih from Tbl_Duyurular";
        public Duyurular()
        {
            InitializeComponent();

            veritabani.gridAktar(dataGridView1, sorgu);
            dataGridView1.Columns[0].Width = 170;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Width = 135;
            dataGridView1.Columns[0].HeaderText = "Duyuru Yapan Kişi";
            dataGridView1.Columns[1].HeaderText = "Duyuru Başlığı";
            dataGridView1.Columns[2].HeaderText = "Duyuru İçeriği";
            dataGridView1.Columns[3].HeaderText = "Duyuru Tarihi";



        }

        private void temizle_btn_Click(object sender, EventArgs e)
        {
            duyuru_rchtbox.Clear();
            dyrBslk_txt.Text = "";
            
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            if (dyrBslk_txt.Text!=""&duyuru_rchtbox.Text != "")
            {
                veritabani.duyuruEkle(dyrBslk_txt.Text, duyuru_rchtbox.Text);
                dyrBslk_txt.Text = "";
                duyuru_rchtbox.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
        }

        private void duyuruGuncelle_btn_Click(object sender, EventArgs e)
        {
            veritabani.gridAktar(dataGridView1, sorgu);
            dyrBslk_txt.Text = "";
            duyuru_rchtbox.Text = "";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            dyrBslk_txt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            duyuru_rchtbox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            adsoyad_lbl.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            
        }
        
        private void duyuruKaldir_btn_Click(object sender, EventArgs e)
        {
            veritabani.duyuruSil(adsoyad_lbl.Text);
        }

        
    }
}
