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
    public partial class Istatistikler : Form
    {
        public Istatistikler()
        {
            InitializeComponent();
            ad_lbl.Text = veritabani.ad;
            soyad_lbl.Text = veritabani.soyad;
            veritabani.gridAktar(para_dtg, "Select doviz_birimi,doviz_kodu,toplam_miktar from tbl_kasa ");
            para_dtg.Columns[0].HeaderText = "Döviz Kodu";
            para_dtg.Columns[1].HeaderText = "Döviz birimi";
            para_dtg.Columns[2].HeaderText = "Toplam Para";

            para_dtg.Columns[0].Width = 300;
            para_dtg.Columns[1].Width = 200;
            para_dtg.Columns[2].Width =270;
            veritabani.gridAktar(sonislem_dtg,"Select * from Tbl_islemler where islemyapan_calisanid="+"'"+veritabani.id+"'"+ " and islem_tarihi>= DATEADD(day, -1, GETDATE())");
            sonislem_dtg.Columns[0].Visible = false;
            sonislem_dtg.Columns[1].Visible = false;
            sonislem_dtg.Columns[4].Visible = false;
            sonislem_dtg.Columns[2].HeaderText = "Müşteri Ad";
            sonislem_dtg.Columns[3].HeaderText = "Müşteri Soyad";
            sonislem_dtg.Columns[5].HeaderText = "Müşteri Tel";
            sonislem_dtg.Columns[6].HeaderText = "Müşteri Mail";
            sonislem_dtg.Columns[7].HeaderText = "Alınan Para Birimi";
            sonislem_dtg.Columns[8].HeaderText = "Verilen Para Birimi";
            sonislem_dtg.Columns[9].HeaderText = "Verilen Para Anlık B.F.";
            sonislem_dtg.Columns[10].HeaderText = "Alınan Para Miktarı";
            sonislem_dtg.Columns[11].HeaderText = "Verilen Para Miktarı";
            sonislem_dtg.Columns[12].HeaderText = "İşlem Tarihi";
            sonislem_dtg.Columns[13].HeaderText = "İşlem Saati";


        }

        private void kasaguncelle_btn_Click(object sender, EventArgs e)
        {
            veritabani.gridAktar(para_dtg, "Select doviz_birimi,doviz_kodu,toplam_miktar from tbl_kasa ");
        }

        private void islemgüncelle_btn_Click(object sender, EventArgs e)
        {
            veritabani.gridAktar(sonislem_dtg, "Select * from Tbl_islemler where islemyapan_calisanid=" + "'" + veritabani.id + "'" + " and islem_tarihi>= DATEADD(day, -1, GETDATE())");
        }
    }
}
