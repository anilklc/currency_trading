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
    public partial class GecmisIslemler : Form
    {
        public GecmisIslemler()
        {
            InitializeComponent();
            ad_lbl.Text = veritabani.ad;
            soyad_lbl.Text = veritabani.soyad;
            baslangic_dtp.Visible = false;
            bitis_dtp.Visible = false;
            baslangic_lbl.Visible = false;
            bitis_lbl.Visible = false;
            veritabani.cmb_Aktar(calisanlar_cmb, "select * from Tbl_users", "user_ad",1);
            siralama_cmb.Items.Add("Personel (Alfabetik)");
            siralama_cmb.Items.Add("Müşteri (Alfabetik)");
            siralama_cmb.Items.Add("2 Tarih Arası");
            siralama_cmb.Items.Add("Alınan Döviz Birimine Göre");
            siralama_cmb.Items.Add("Satılan Döviz Birimine Göre");
            baslangic_dtp.Format = DateTimePickerFormat.Custom;
            baslangic_dtp.CustomFormat = "yyyy'-'MM'-'dd";
            bitis_dtp.Format = DateTimePickerFormat.Custom;
            bitis_dtp.CustomFormat = "yyyy'-'MM'-'dd";
         }
        string sorgu = "",tur;

        private void gridBasliklar()
        {
            islemler_dtg.Columns[0].HeaderText = "Çalışan Ad-Soyad";
            islemler_dtg.Columns[1].HeaderText = "Müşteri Ad-Soyad";
            islemler_dtg.Columns[2].HeaderText = "Müşteri TC";
            islemler_dtg.Columns[3].HeaderText = "Müşteri Tel";
            islemler_dtg.Columns[4].HeaderText = "Müşteri Mail";
            islemler_dtg.Columns[5].HeaderText = "Alınan Para Birimi";
            islemler_dtg.Columns[6].HeaderText = "Verilen Para Birimi";
            islemler_dtg.Columns[7].HeaderText = "Verilen Para Anlık B.F.";
            islemler_dtg.Columns[8].HeaderText = "Alınan Para Miktarı";
            islemler_dtg.Columns[9].HeaderText = "Verilen Para Miktarı";
            islemler_dtg.Columns[10].HeaderText = "İşlem Tarihi";
            islemler_dtg.Columns[11].HeaderText = "İşlem Saati";
        }
        private void listele_btn_Click(object sender, EventArgs e)
        {
            if (calisanlar_cmb.Text!="")
            {
                tur = tur = calisanlar_cmb.Text + " Adlı Personelin Tüm İşlemleri";
                sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,Tbl_islemler.m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid where user_ad+' '+user_soyad=" + "'" + calisanlar_cmb.Text + "'";
                veritabani.gridAktar(islemler_dtg, sorgu);
                gridBasliklar();

            }
            else
            {
                MessageBox.Show("Lütfen Bir Çalışan Seçiniz");
            }
            
        }

        private void siralama_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siralama_cmb.SelectedIndex==2)
            {
                baslangic_dtp.Visible =true;
                bitis_dtp.Visible =true;
                baslangic_lbl.Visible = true;
                bitis_lbl.Visible = true;
            }
            else
            {
                baslangic_dtp.Visible = false;
                bitis_dtp.Visible = false;
                baslangic_lbl.Visible = false;
                bitis_lbl.Visible = false;
            }
        }

        private void listele2_btn_Click(object sender, EventArgs e)
        {
            if (siralama_cmb.SelectedIndex == 0)
            {
                
                if (calisanlar_cmb.Text!="")
                {
                    tur = "Personel Alfabetik";
                    sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid  where user_ad+' '+user_soyad=" + "'" + calisanlar_cmb.Text + "'" + "order by user_ad+' '+user_soyad";
                    veritabani.gridAktar(islemler_dtg, sorgu);
                }
                else
                {
                    tur = "Personeller Alfabetik";
                    sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid order by user_ad+' '+user_soyad";
                    veritabani.gridAktar(islemler_dtg, sorgu);
                }
                gridBasliklar();

            }
            else if (siralama_cmb.SelectedIndex == 1)
            {
               
                if (calisanlar_cmb.Text != "")
                {
                    tur = calisanlar_cmb.Text+ " Adlı Personelin Müşterileri Alfabetik ";
                    sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid  where user_ad+' '+user_soyad=" + "'" + calisanlar_cmb.Text + "'" + "order by m_ad+' '+m_soyad";
                    veritabani.gridAktar(islemler_dtg, sorgu);
                }
                else
                {
                    tur = "Tüm Personeller Müşteriler Alfabetik";
                    sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid order by m_ad+' '+m_soyad";
                    veritabani.gridAktar(islemler_dtg, sorgu); 
                }
                gridBasliklar();
            }
            else if (siralama_cmb.SelectedIndex == 2)
            {
                string baslangic = baslangic_dtp.Text;
                string bitis = bitis_dtp.Text;
                if (calisanlar_cmb.Text != "")
                {
                    tur = calisanlar_cmb.Text + " Adlı Personelin 2 Tarih Arası İşlemleri";
                    sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid  where user_ad+' '+user_soyad=" + "'" + calisanlar_cmb.Text + "'" + " and islem_tarihi>=" + "'" + baslangic + "'" + "and islem_tarihi<=" + "'" + bitis + "'";
                   veritabani.gridAktar(islemler_dtg, sorgu);
                }
                else
                {
                    tur = "Tüm Personellerin 2 Tarih Arası İşlemleri";
                    sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,Tbl_islemler.m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid  where islem_tarihi>=" + "'" + baslangic + "'" + "and islem_tarihi<=" + "'" + bitis + "'";
                       veritabani.gridAktar(islemler_dtg, sorgu);
                }
                gridBasliklar();
            }
            else if (siralama_cmb.SelectedIndex == 3)
            {
               
                if (calisanlar_cmb.Text != "")
                {
                    tur = calisanlar_cmb.Text + " Adlı Personelin Alınan Döviz Birimine Göre İşlemleri";
                    sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,Tbl_islemler.m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid  where user_ad+' '+user_soyad=" + "'" + calisanlar_cmb.Text + "'" + "order by m_Alincak_paraBirimi";
                    veritabani.gridAktar(islemler_dtg, sorgu);
                 }
                else
                {
                    tur ="Tüm Personellerin Alınan Döviz Birimine Göre İşlemleri";
                    sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,Tbl_islemler.m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid order by m_Alincak_paraBirimi";
                    veritabani.gridAktar(islemler_dtg, sorgu);
                }
                gridBasliklar();
            }
            else if (siralama_cmb.SelectedIndex == 4)
            {
                
                if (calisanlar_cmb.Text != "")
                {
                    tur = calisanlar_cmb.Text + "Tüm Personellerin Satılınan Döviz Birimine Göre İşlemleri";
                    sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,Tbl_islemler.m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid  where user_ad+' '+user_soyad=" + "'" + calisanlar_cmb.Text + "'" + "m_Verilcek_paraBirimi";
                    veritabani.gridAktar(islemler_dtg, sorgu);
                }
                else
                {
                    tur = "Tüm Personellerin Satılan Döviz Birimine Göre İşlemleri";
                    sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,Tbl_islemler.m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid order by m_Verilcek_paraBirimi";
                    veritabani.gridAktar(islemler_dtg, sorgu);
                }
                gridBasliklar();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Sıralama Filtresi Seçiniz");
            }
            
        }
       
        private void tlistele_btn_Click(object sender, EventArgs e)
        {
            tur = "Tüm Personellerin İşlemleri";
            sorgu = "select user_ad+' '+user_soyad,m_ad+' '+m_soyad,Tbl_islemler.m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati FROM Tbl_users INNER JOIN Tbl_islemler ON Tbl_users.user_id = Tbl_islemler.islemyapan_calisanid";
            veritabani.gridAktar(islemler_dtg, sorgu);
            gridBasliklar();
            
        }

        private void rapor_btn_Click(object sender, EventArgs e)
        {
            if (sorgu!=""&tur!="")
            {
                Rapor_Olusturma a = new Rapor_Olusturma();
                a.sorgu = sorgu;
                a.tur = tur;
                a.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Rapor Oluşturmadan Önce Bir İşlem Sorgusu Yapınız");
            }
           
        }
    }
}
