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
    public partial class KullanıcıOlustur : Form
    {
        public KullanıcıOlustur()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            adi_text.Text="";
            soyadi_text.Text = "";
            tc_msktxt.Text = "";
            kullaniciAdi_txt.Text = "";
            sifre_txt.Text = "";
            tel_msktxt.Text = "";
            mail_txt.Text = "";
            dogumtarihi_msktxt.Text = "";
            yonetici_rbtn.Checked = false;
            calisan_rbtn.Checked = false;
        }
        private void kaydet_btn_Click(object sender, EventArgs e)
        {
           
                string ad = adi_text.Text;
                string soyad = soyadi_text.Text;
                string tc = tc_msktxt.Text;
                string kullaniciAdi = kullaniciAdi_txt.Text;
                string psw = sifre_txt.Text;
                string tel = tel_msktxt.Text;
                string mail = mail_txt.Text;
                string dgmtrh = dogumtarihi_msktxt.Text;
                string yetkisi;
                if (yonetici_rbtn.Checked)
                {
                    yetkisi = "True";
                }
                else
                {
                    yetkisi = "False";

                }

            if (ad != "" & soyad != "" & tc != "" & kullaniciAdi != "" & psw != "" & tel != "" & mail != "" & dgmtrh != "" & yetkisi != "")
            {
                veritabani.kullaniciEkle(ad, soyad, tc, kullaniciAdi, psw, tel, mail, dgmtrh, yetkisi);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
            
          
            }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            veritabani.kullaniciSil(tcsil_msktxt.Text);
            tcsil_msktxt.Text = "";
        }
    }
    }

