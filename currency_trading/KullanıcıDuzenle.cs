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
    public partial class KullanıcıDuzenle : Form
    {
        public KullanıcıDuzenle()
        {
            InitializeComponent();


        }

        private void KullanıcıDuzenle_Load(object sender, EventArgs e)
        {
            id_txt.Enabled = false;
            sifre_txt.Enabled = false;
            if (veritabani.yetki == "True")
            {
                bul_btn.Visible = true;

            }
            else
            {
                adi_txt.Enabled = false;
                soyadi_txt.Enabled = false;
                tc_msktxt.Enabled = false;
                kullaniciAdi_txt.Enabled = false;
                dogumtarihi_msktxt.Enabled = false;
                yonetici_rbtn.Enabled = false;
                calisan_rbtn.Enabled = false;
                bul_btn.Visible = false;
            }
            
            veritabani.kullaniciTextAktar();
            id_txt.Text = veritabani.aktar_id;
            adi_txt.Text = veritabani.aktar_ad;
            soyadi_txt.Text = veritabani.aktar_soyad;
            tc_msktxt.Text = veritabani.aktar_tc;
            kullaniciAdi_txt.Text = veritabani.aktar_nick;
            
            tel_msktxt.Text = veritabani.aktar_tel;
            mail_txt.Text = veritabani.aktar_mail;
            dogumtarihi_msktxt.Text = veritabani.aktar_dgmtrh;
            
            if (veritabani.aktar_yetkisi == "True")
            {
                yonetici_rbtn.Checked = true;
            }
            else
            {
                calisan_rbtn.Checked = true;

            }
            }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            string id = id_txt.Text;
            string ad = adi_txt.Text;
            string soyad = soyadi_txt.Text;
            string tc = tc_msktxt.Text;
            string kullaniciAdi = kullaniciAdi_txt.Text;
            string psw="";
            string tel = tel_msktxt.Text;
            string mail = mail_txt.Text;
            string dgmtrh = dogumtarihi_msktxt.Text;
            string yetkisi = "false";
            if (yonetici_rbtn.Checked)
            {
                yetkisi = "true";
            }
            else
            {
                yetkisi = "false";

            }
            if (sifre_rbtn.Checked)
            {
                psw = sifre_txt.Text;
                if (id != "" & ad != "" & soyad != "" & tc != "" & kullaniciAdi != "" & psw != "" & tel != "" & mail != "" & dgmtrh != "" & yetkisi != "")
                {
                    veritabani.kullaniciGuncelle(id, ad, soyad, tc, kullaniciAdi, veritabani.sifrele(psw), tel, mail, dgmtrh, yetkisi);
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                }

            }
            else
            {
                if (id != "" & ad != "" & soyad != "" & tc != "" & kullaniciAdi != ""  & tel != "" & mail != "" & dgmtrh != "" & yetkisi != "")
                {
                    psw = veritabani.aktar_psw;
                    veritabani.kullaniciGuncelle(id, ad, soyad, tc, kullaniciAdi, psw, tel, mail, dgmtrh, yetkisi);

                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                }
            }
        }
        
        private void bul_btn_Click(object sender, EventArgs e)
        {
           veritabani.kontrol_tc = tc_msktxt.Text;
            veritabani.kullaniciTextAktar();
            id_txt.Text = veritabani.aktar_id;
            adi_txt.Text = veritabani.aktar_ad;
            soyadi_txt.Text = veritabani.aktar_soyad;
            tc_msktxt.Text = veritabani.aktar_tc;
            kullaniciAdi_txt.Text = veritabani.aktar_nick;
            tel_msktxt.Text = veritabani.aktar_tel;
            mail_txt.Text = veritabani.aktar_mail;
            dogumtarihi_msktxt.Text = veritabani.aktar_dgmtrh;

            if (veritabani.aktar_yetkisi == "True")
            {
                yonetici_rbtn.Checked = true;
            }
            else
            {
                calisan_rbtn.Checked = true;

            }
        }

        private void sifre_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sifre_rbtn.Checked)
            {
                sifre_txt.Enabled = true;
            }
            else
            {
                sifre_txt.Enabled = false;
            }
        }
    }
}
