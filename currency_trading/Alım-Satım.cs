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
    public partial class Alım_Satım : Form
    {
        float alincakpbf = 0, satilcakpbf = 0;
        public Alım_Satım()
        {
           
            InitializeComponent();
            veritabani.cmb_Aktar(alincak_cmb, "select * from Tbl_kasa","doviz_birimi",0);
            veritabani.cmb_Aktar(satilcak_cmb,"select * from Tbl_kasa", "doviz_birimi",0);
            islembitir_btn.Enabled = false;
        }

        private void temizle() {
            adi_text.Text = "";
            soyadi_text.Text = "";
            tc_msktxt.Text = "";
            tel_msktxt.Text = "";
            mail_txt.Text = "";
            alincak_cmb.Text = "";
            satilcak_cmb.Text = "";
            alincak_miktar_txt.Text = "";
            alincakTutar_lbl.Text = "0.000";
            verilcekTutar_lbl.Text = "0.000";
            verilcekTutarDkodu_lbl.Text = "";
            alincakTutarDkodu_lbl.Text = "";
            evet_rbtn.Checked = false;
            hayir_rbtn.Checked = false;
        }

        private bool kontrol()
        {
            if (adi_text.Text != "" & soyadi_text.Text != "" & tc_msktxt.Text != "" & tel_msktxt.Text != "" & mail_txt.Text != "" & alincak_cmb.Text != "" & satilcak_cmb.Text != "" & alincak_miktar_txt.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                return false;
            }

        }


       
        private void temizle_btn_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void islembitir_btn_Click(object sender, EventArgs e)
        {
            if (kontrol() & evet_rbtn.Checked)
            {
                veritabani.musteri_ekle(adi_text.Text, soyadi_text.Text, tc_msktxt.Text, tel_msktxt.Text, mail_txt.Text, alincak_cmb.Text, satilcak_cmb.Text, satilcakBirim_lbl.Text, alincakTutar_lbl.Text, verilcekTutar_lbl.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz Ve Onay Butonunu İşaretleyiniz...");
            }
        }

        private void hesapla_btn_Click(object sender, EventArgs e)
        {
            if (kontrol() & alincak_cmb.Text != satilcak_cmb.Text)
            {
                MessageBox.Show("Lütfen Onay Butonunu İşaretleyiniz Aksi Takdirde İşlem Onaylanmıycaktır");
                veritabani.al_ver_hesaplama((float)Convert.ToDouble(alincak_miktar_txt.Text),alincakpbf,satilcakpbf);
                verilcekTutar_lbl.Text = veritabani.sonuc.ToString("0.##");
                alincakTutar_lbl.Text = alincak_miktar_txt.Text;
                islembitir_btn.Enabled = true;
                veritabani.dovizkodu_yazdir(satilcak_cmb.Text);
                verilcekTutarDkodu_lbl.Text = veritabani.dovizkodu;
               veritabani.dovizkodu_yazdir(alincak_cmb.Text);
                alincakTutarDkodu_lbl.Text =  veritabani.dovizkodu;
                verilcekTutarDkodu_lbl.Enabled = true;
                alincakTutarDkodu_lbl.Enabled = true;
            }
            else if (alincak_cmb.Text == satilcak_cmb.Text)
            {
               MessageBox.Show("Lutfen Farklı Para Birimleri Arasında İşlem Yapınız...");
            }
        }

        private void satilcak_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (satilcak_cmb.Text!="TÜRK LİRASI")
            {
               veritabani.anlikfiyat_Aktarsatis(satilcak_cmb.Text);
               satilcakpbf = (float)Convert.ToDouble(veritabani.anlik);
               satilcakBirim_lbl.Text = veritabani.anlik;
             }
            else
            {
                satilcakBirim_lbl.Text = "1.000";
                satilcakpbf = 1;
            }

           
        }

        private void alincak_miktar_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void alincak_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (alincak_cmb.Text != "TÜRK LİRASI")
            {
                veritabani.anlikfiyat_Aktaralis(alincak_cmb.Text);
                alincakpbf = (float)Convert.ToDouble(veritabani.anlik);
            }
            else
            {
                alincakpbf = 1;
            }
        }
    }
}
