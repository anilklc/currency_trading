using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;
using System.Xml;

namespace _202503077
{
    class veritabani
    {
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;

        public static string baglan = @"Data Source=DESKTOP-KRI4FEI;Initial Catalog=202503077;Integrated Security=True";

        //veritabani baglanti kontrol baslangic 

        public static bool baglantikontrol()
        {
            using (con = new SqlConnection(baglan))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException exp)
                {
                    MessageBox.Show(exp.Message);
                    return false;
                }

            }
        }

        //veritabani baglanti kontrol bitis

        //datagrid veri aktarma baslangic
        public static DataGridView gridAktar(DataGridView dt, string sorgu)
        {
            
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter(sorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, sorgu);
            dt.DataSource = ds.Tables[sorgu];
            con.Close();
            return dt;
        }
        //datagrid veri aktarma bitis

        //md5 şifreleme baslangic
        public static string sifrele(string sifre)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifre);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
                sb.Append(item.ToString("x2").ToLower());

            return sb.ToString();

        }
        //md5 sifreleem bitis

        public static string yetki="False";
        public static string ad, soyad, id;

        //kullanıcı giriş başlangıç
        public static void giris_kontrol(string kullaniciAdi, string sifre)
        {
            
            con = new SqlConnection(baglan);
            cmd = new SqlCommand("select * from tbl_users where user_nick=@userNick and user_psw=@userPsw", con);
            cmd.Parameters.AddWithValue("@userNick", kullaniciAdi);
            cmd.Parameters.AddWithValue("@userPsw", sifrele(sifre));
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                yetki = dr["user_yetki"].ToString();
                idveadSoyad_kontrol(kullaniciAdi);
                songiristarihi(kullaniciAdi, DateTime.Now);
                Form frm = new AnaPanel();
                GirisPaneli.ActiveForm.Hide();
                frm.Show();
            }
            
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                
            }
            con.Close();
        }

        //kullanıcı giriş bitiş
        //kullanıcıını son giriş tarihi ekleme başlangıç
        public static void songiristarihi(string kullaniciadi, DateTime giristrh)
        {
            con = new SqlConnection(baglan);

            cmd = new SqlCommand("update Tbl_users set user_songiristrh=@tarih where user_nick=@userNick", con);
            cmd.Parameters.AddWithValue("@userNick", kullaniciadi);
            cmd.Parameters.AddWithValue("@tarih", giristrh);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //kullanıcıını son giriş tarihi ekleme bitiş

        //kullanıcı adı veya TC kimlik nuamrasının başkasında olup olmadığını knotrol başlangıç
        public static bool kullaniciEkle_Kontrol(string kullaniciAdi, string tc)
        {
            con = new SqlConnection(baglan);
            cmd = new SqlCommand("select * from Tbl_users where user_nick=@userNick or user_tc=@userTc", con);
            cmd.Parameters.AddWithValue("@userNick", kullaniciAdi);
            cmd.Parameters.AddWithValue("@userTc", tc);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bu Kullanıcı Adında Veya TC kimlik Numarasına Ait\nBir Üye Çalışan Bulunmakta!!!");
                con.Close();
                return false;
            }
            else
            {
                con.Close();
                return true;
            }
            
        }

        //kullanıcı adı veya TC kimlik nuamrasının başkasında olup olmadığını knotrol bitiş

        //kullanıcı ekle başlangıç
        public static void kullaniciEkle(string ad, string soyad, string tc, string kullaniciAdi, string psw, string tel, string mail, string dgmtrh, string yetkisi)
        {
            if (kullaniciEkle_Kontrol(kullaniciAdi, tc))
            {
                con = new SqlConnection(baglan);
                cmd = new SqlCommand("insert into Tbl_users (user_ad,user_soyad,user_tc,user_nick,user_psw,user_tel,user_mail,user_dgmtrh,user_yetki,user_olusturulmatrh) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10)", con);
                cmd.Parameters.AddWithValue("@a1", ad);
                cmd.Parameters.AddWithValue("@a2", soyad);
                cmd.Parameters.AddWithValue("@a3", tc);
                cmd.Parameters.AddWithValue("@a4", kullaniciAdi);
                cmd.Parameters.AddWithValue("@a5", sifrele(psw));
                cmd.Parameters.AddWithValue("@a6", tel);
                cmd.Parameters.AddWithValue("@a7", mail);
                cmd.Parameters.AddWithValue("@a8", dgmtrh);
                cmd.Parameters.AddWithValue("@a9", yetkisi);
                cmd.Parameters.AddWithValue("@a10", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Çalışan Başarıyla Eklendi");
                con.Close(); 
            }
        }

        //kullanıcı ekle bitiş

        //TC kimlik nuamrasının olup olmadığını kontrol başlangıç
        public static bool kullaniciSil_Kontrol(string tc)
        {

            cmd = new SqlCommand("select * from Tbl_users where user_tc=@userTc", con);

            cmd.Parameters.AddWithValue("@userTc", tc);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                MessageBox.Show("Bu TC kimlik Numarasına Ait\nBir Üye Çalışan Bulunmamaktadır!!!");
                return false;
            }
        }

        //TC kimlik nuamrasının olup olmadığını kontrol  bitiş

        //kullanıcı sil başlangıç

        public static void kullaniciSil(string tc)
        {
            if (kullaniciSil_Kontrol(tc))
            {
                con = new SqlConnection(baglan);
                cmd = new SqlCommand("delete from Tbl_users where user_tc=@usertc", con);
                cmd.Parameters.AddWithValue("@usertc", tc);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Çalışan Başarıyla Silindi");
            }
        }

        //kullanıcı sil bitiş
        //duyuru ekleme başlangıç
        public static void duyuruEkle(string duyuruismi,string duyuru)
        {
            con = new SqlConnection(baglan);

            cmd = new SqlCommand("insert into  Tbl_duyurular (duyuru_ismi,duyuru,user_id,duyuruyu_yapan,duyuru_tarih) values(@duyuruismi,@duyuru,@user_id,@user_adSoyad,@duyurutrh)", con);
            cmd.Parameters.AddWithValue("@duyuruismi", duyuruismi);
            cmd.Parameters.AddWithValue("@duyuru", duyuru);
            cmd.Parameters.AddWithValue("@user_id", id); 
            cmd.Parameters.AddWithValue("@user_adSoyad", ad+" "+soyad);
            cmd.Parameters.AddWithValue("@duyurutrh", DateTime.Now);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Duyuru Başarıyla Eklendi");
        }
        //duyuru ekleme bitiş

        //kullanıcı id adsoyad aktarma başlangıç
        public static bool idveadSoyad_kontrol(string kullaniciAdi)
        {
            con = new SqlConnection(baglan);
            cmd = new SqlCommand("select * from Tbl_users where user_nick=@userNick", con);
            cmd.Parameters.AddWithValue("@userNick", kullaniciAdi);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr["user_id"].ToString();
                ad = dr["user_ad"].ToString();
                soyad = dr["user_soyad"].ToString();
                con.Close();
                return true ;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        //kullanıcı id adsoyad aktarma bitiş
        //Duyuru silme başlangıç
        public static void duyuruSil(string duyuruYapan)
        {
            if (duyuruYapan==ad+" "+soyad || yetki=="True")
            {
                con = new SqlConnection(baglan);

                cmd = new SqlCommand("delete from Tbl_Duyurular where duyuruyu_yapan=@user_adSoyad", con);

                cmd.Parameters.AddWithValue("@user_adSoyad", duyuruYapan);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Duyuru Başarıyla Silindi");
            }
            else
            {
                MessageBox.Show("Duyuru Silinemedi");
            }
            
        }
        //duyuru silme bitiş
        //kullanıcı verilerini güncelleme başlangıç
        public static void kullaniciGuncelle(string idsi,string ad, string soyad, string tc, string kullaniciAdi, string psw, string tel, string mail, string dgmtrh, string yetkisi)
        {
            con = new SqlConnection(baglan);
            cmd = new SqlCommand("update Tbl_users set user_ad=@a1,user_soyad=@a2,user_tc=@a3,user_nick=@a4,user_psw=@a5,user_tel=@a6,user_mail=@a7,user_dgmtrh=@a8,user_yetki=@a9 where user_id=@a10", con);
            cmd.Parameters.AddWithValue("@a1", ad);
            cmd.Parameters.AddWithValue("@a2", soyad);
            cmd.Parameters.AddWithValue("@a3", tc);
            cmd.Parameters.AddWithValue("@a4", kullaniciAdi);
            cmd.Parameters.AddWithValue("@a5", psw);
            cmd.Parameters.AddWithValue("@a6", tel);
            cmd.Parameters.AddWithValue("@a7", mail);
            cmd.Parameters.AddWithValue("@a8", Convert.ToDateTime(dgmtrh));
            cmd.Parameters.AddWithValue("@a9", yetkisi);
            cmd.Parameters.AddWithValue("@a10", idsi);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bilgiler Başarıyla Güncellendi");
        }
        //kullanıcı verileri güncelleme bitiş
        //kullanıcı verilerini textboxa aktarma başlangıç
        public static string kontrol_tc = " ";
        public static string aktar_id, aktar_ad, aktar_soyad, aktar_tc, aktar_nick, aktar_psw, aktar_tel, aktar_mail, aktar_dgmtrh, aktar_yetkisi;
        public static void kullaniciTextAktar()
        {
            if (yetki == "True" &kontrol_tc!=" ")
            {
                con = new SqlConnection(baglan);
                cmd = new SqlCommand("select * from Tbl_users where user_tc = @usertc", con);
                cmd.Parameters.AddWithValue("@usertc", kontrol_tc);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    aktar_id = dr["user_id"].ToString();
                    aktar_ad = dr["user_ad"].ToString();
                    aktar_soyad = dr["user_soyad"].ToString();
                    aktar_tc = dr["user_tc"].ToString();
                    aktar_nick = dr["user_nick"].ToString();
                    aktar_psw = dr["user_psw"].ToString();
                    aktar_tel = dr["user_tel"].ToString();
                    aktar_mail = dr["user_mail"].ToString();
                    aktar_dgmtrh = dr["user_dgmtrh"].ToString();
                    aktar_yetkisi = dr["user_yetki"].ToString();
                   
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı!!!");
                    con.Close();
                }
                
            }
            else
            {
                con = new SqlConnection(baglan);
                cmd = new SqlCommand("select * from Tbl_users where user_id = @userid", con);
                cmd.Parameters.AddWithValue("@userid", id);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    aktar_id = dr["user_id"].ToString();
                    aktar_ad = dr["user_ad"].ToString();
                    aktar_soyad = dr["user_soyad"].ToString();
                    aktar_tc = dr["user_tc"].ToString();
                    aktar_nick = dr["user_nick"].ToString();
                    aktar_psw = dr["user_psw"].ToString();
                    aktar_tel = dr["user_tel"].ToString();
                    aktar_mail = dr["user_mail"].ToString();
                    aktar_dgmtrh = dr["user_dgmtrh"].ToString();
                    aktar_yetkisi = dr["user_yetki"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı!!!");
                    con.Close();
                }

            }
        }
        //kullanıcı verilerini textboxa aktarma bitiş

        //xml verileri datagride aktarma başlangıç
        public static void xmlAktar(DataGridView dtg) {
            ds = new DataSet();
            ds.ReadXml(@"https://www.tcmb.gov.tr/kurlar/today.xml");
            dtg.DataSource = ds.Tables[1];
        }

        //xml verileri datagride aktarma bitiş

        //para birimi ekle kontrol başlangıç

        public static bool ParabirimiEkle_Kontrol(string dkodu)
        {
            con = new SqlConnection(baglan);
            cmd = new SqlCommand("select * from Tbl_kasa where doviz_kodu=@dkodu", con);
            cmd.Parameters.AddWithValue("@dkodu", dkodu);
            
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bu Para Birimi Bulunmaktadır");
                con.Close();
                return false;
            }
            else
            {
                con.Close();
                return true;
            }

        }

        //para birimi ekle kontrol bitiş

        //para birimi ekle başlangıç
        public static void paraBirimiEkle(string dbirimi,string dkodu,string toplamMiktar)
        {
            if (ParabirimiEkle_Kontrol(dkodu))
            {
                con = new SqlConnection(baglan);
                cmd = new SqlCommand("insert into Tbl_kasa (doviz_birimi,doviz_kodu,toplam_miktar,islem_yapankisi,islem_tarihi) values (@a1,@a2,@a3,@a4,@a5)", con);
                cmd.Parameters.AddWithValue("@a1", dbirimi);
                cmd.Parameters.AddWithValue("@a2", dkodu);
                cmd.Parameters.AddWithValue("@a3", toplamMiktar);
                cmd.Parameters.AddWithValue("@a4", ad+" "+soyad);
                cmd.Parameters.AddWithValue("@a5", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Para Birimi Başarıyla Eklendi");
                con.Close();
            }
        }

        //parabirimi ekle bitiş

        
        //para birimi sil başlangıç
        public static void paraBirimiCikar(string dbirimi)
        {
            con = new SqlConnection(baglan);
            cmd = new SqlCommand("delete from Tbl_kasa where doviz_birimi=@a1", con);  
            cmd.Parameters.AddWithValue("@a1", dbirimi);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Para Birimi Başarıyla Silindi");
            con.Close();
        }

        //parabirimi sil bitiş

        //toplam para ekle-çıkar başlangıç
        public static float toplamTutar;
        public static void toplamPara(string dbirimi, string eklenenTutar,string cikarilantutar)
        {
            
            con = new SqlConnection(baglan);
            cmd = new SqlCommand("select * from Tbl_kasa where doviz_birimi=@a1", con);
            cmd.Parameters.AddWithValue("@a1", dbirimi);
           
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                toplamTutar= (float)Convert.ToDouble(dr["toplam_miktar"].ToString());

                if (eklenenTutar!=null)
                {
                    toplamTutar=toplamTutar +(float)Convert.ToDouble(eklenenTutar); 
                }
               else  if (cikarilantutar != null & toplamTutar>(float)Convert.ToDouble(cikarilantutar))
                {
                    toplamTutar = toplamTutar - (float)Convert.ToDouble(cikarilantutar);
                }

            }
            con.Close();
        }

        //toplam para ekle çıkar bitiş

        //para ekle başlangıç
        public static void paraEkle(string dbirimi, string eklenentutar)
        {
            string cikarilantutar = null;
            toplamPara(dbirimi,eklenentutar,cikarilantutar);
                con = new SqlConnection(baglan);
                cmd = new SqlCommand("update Tbl_kasa set eklenen_miktar=@a2,toplam_miktar=@a3,islem_yapankisi=@a4,islem_tarihi=@a5 where doviz_birimi=@a1", con);
                cmd.Parameters.AddWithValue("@a1", dbirimi);
                cmd.Parameters.AddWithValue("@a2", eklenentutar);
                cmd.Parameters.AddWithValue("@a3", Convert.ToString(toplamTutar)); 
                cmd.Parameters.AddWithValue("@a4", ad + " " + soyad);
                cmd.Parameters.AddWithValue("@a5", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            
        }

        //para ekle bitiş

        //para çıkar başlangıç
        public static void paraCikar(string dbirimi, string cikarilantutar)
        {
            string eklenentutar = null;
            toplamPara(dbirimi, eklenentutar, cikarilantutar);
            con = new SqlConnection(baglan);
            cmd = new SqlCommand("update Tbl_kasa set cikarilan_miktar=@a2,toplam_miktar=@a3,islem_yapankisi=@a4,islem_tarihi=@a5 where doviz_birimi=@a1", con);
            cmd.Parameters.AddWithValue("@a1", dbirimi);
            cmd.Parameters.AddWithValue("@a2", cikarilantutar);
            cmd.Parameters.AddWithValue("@a3", Convert.ToString(toplamTutar));
            cmd.Parameters.AddWithValue("@a4", ad + " " + soyad);
            cmd.Parameters.AddWithValue("@a5", DateTime.Now);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //para çıkar bitiş

        //cmb xml başlangıç
        public static void cmb_xmlAktar(ComboBox cmb,int x) {
            ds = new DataSet();
            ds.ReadXml(@"https://www.tcmb.gov.tr/kurlar/today.xml");
            XmlTextReader aktar = new XmlTextReader(@"https://www.tcmb.gov.tr/kurlar/today.xml");
            int i = 0;
            
            while (aktar.Read())
            {
                if (i != 22)
                {
                    cmb.Items.Add(ds.Tables[1].Rows[i][x].ToString());
                    i++;
                }
            }
        }
        //cmb xml bitiş

        //cmb aktar başlangıç
        public static void cmb_Aktar(ComboBox cmb, string sorgu, string index,int secenek)
        { string index2="user_soyad";
            con = new SqlConnection(baglan);
            cmd = new SqlCommand(sorgu, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (secenek == 1)
            {
                while (dr.Read())
                {
                    cmb.Items.Add(dr[index].ToString() +" " +dr[index2].ToString());
                }
            }
            else
            {
                while (dr.Read())
                {
                    cmb.Items.Add(dr[index].ToString());
                }
            }
            con.Close();
        }
        //cmb aktar bitiş

        //toplam tutar aktarma başlangıç
        public static string toplamtutarAktar;
        public static void toplamtutar_Aktar(string dovizbirim)
        {
            con = new SqlConnection(baglan);
            cmd = new SqlCommand("select * from Tbl_kasa where doviz_birimi=@a1", con);
            cmd.Parameters.AddWithValue("@a1", dovizbirim);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                toplamtutarAktar=(dr["toplam_miktar"].ToString());
            }
            con.Close();
        }
        //toplam tutar aktarma bitiş

        //musteri ekle başlangıç
        public static void musteri_ekle(string m_ad,string m_soyad,string m_tc,string m_tel,string m_mail,string m_alincak_parabirimi,string m_satilcak_parabirimi, string m_satilcak_parabfiyati, string m_alincak_paramiktari, string m_satilcak_paramiktari)
        {
            if (kasa_kontrol(m_satilcak_parabirimi,m_satilcak_paramiktari))
            {
                con = new SqlConnection(baglan);
                cmd = new SqlCommand("insert into Tbl_islemler (islemyapan_calisanid,m_ad,m_soyad,m_tc,m_tel,m_mail,m_Alincak_paraBirimi,m_Verilcek_paraBirimi,m_VerilcekParaBirimi_anlikFiyati,m_Alincak_paraMiktari,m_Verilcek_paraMiktari,islem_tarihi,islem_saati) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13)", con);
                cmd.Parameters.AddWithValue("@a1", id);
                cmd.Parameters.AddWithValue("@a2", m_ad);
                cmd.Parameters.AddWithValue("@a3", m_soyad);
                cmd.Parameters.AddWithValue("@a4", m_tc);
                cmd.Parameters.AddWithValue("@a5", m_tel);
                cmd.Parameters.AddWithValue("@a6", m_mail);
                cmd.Parameters.AddWithValue("@a7", m_alincak_parabirimi);
                cmd.Parameters.AddWithValue("@a8", m_satilcak_parabirimi);
                cmd.Parameters.AddWithValue("@a9", m_satilcak_parabfiyati);
                cmd.Parameters.AddWithValue("@a10", m_alincak_paramiktari);
                cmd.Parameters.AddWithValue("@a11", m_satilcak_paramiktari);
                cmd.Parameters.AddWithValue("@a12", DateTime.Now);
                cmd.Parameters.AddWithValue("@a13", DateTime.Now.ToLongTimeString());
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarılı");
                paraEkle(m_alincak_parabirimi,m_alincak_paramiktari);
                paraCikar(m_satilcak_parabirimi, m_satilcak_paramiktari);
                con.Close();
            }
            

        }
        //musteri ekle bitiş

        //anlık kur ve döviz kodu başlangıç
        public static string anlik, dovizkodu;
        public static void anlikfiyat_Aktaralis(string doviz )
        {
            ds = new DataSet();
            ds.ReadXml(@"https://www.tcmb.gov.tr/kurlar/today.xml");
            XmlTextReader aktar = new XmlTextReader(@"https://www.tcmb.gov.tr/kurlar/today.xml");
            int i = 0;

            while (aktar.Read())
            {
              
                    if (i != 22)
                    {
                        if (ds.Tables[1].Rows[i][1].ToString() == doviz)
                        {
                            anlik = ds.Tables[1].Rows[i][3].ToString();
                            
                        }
                        i++;
                    
                    }
            }


        }
        public static void anlikfiyat_Aktarsatis(string doviz)
        {
            ds = new DataSet();
            ds.ReadXml(@"https://www.tcmb.gov.tr/kurlar/today.xml");
            XmlTextReader aktar = new XmlTextReader(@"https://www.tcmb.gov.tr/kurlar/today.xml");
            int i = 0;

            while (aktar.Read())
            {
                
                    if (i != 22)
                    {
                        if (ds.Tables[1].Rows[i][1].ToString() == doviz)
                        {
                            anlik = ds.Tables[1].Rows[i][4].ToString();
                           
                        }
                        i++;
                    }
            }


        }
        public static void dovizkodu_yazdir(string dbirimi)
        {

            con = new SqlConnection(baglan);
            cmd = new SqlCommand("select * from Tbl_kasa where doviz_birimi=@a1", con);
            cmd.Parameters.AddWithValue("@a1", dbirimi);

            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dovizkodu = dr["doviz_kodu"].ToString();
            }
        }
        //anlık kur ve döviz kodu bitiş
        //kasa kontrol başlangıç
        public static bool kasa_kontrol(string dbirimi,string satilcaktutar)
        {
            con = new SqlConnection(baglan);
            cmd = new SqlCommand("select * from Tbl_kasa where doviz_birimi=@a1", con);
            cmd.Parameters.AddWithValue("@a1", dbirimi);

            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                toplamTutar = (float)Convert.ToDouble(dr["toplam_miktar"].ToString());
                if (toplamTutar>= (float)Convert.ToDouble(satilcaktutar.ToString()))
                {
                    con.Close();
                    return true;
                    
                }
                else
                {
                    MessageBox.Show("Kasada Yeterli Bakiye Bulunmamaktadır...");
                    return false;
                }
            }
           
            else
            {
                return false;
            }
            
          
            
        }

        //kasa kontrol bitiş
        //müşteriden alıncak ve verilcek tutarı hesaplama başlangıç
        public static float sonuc;
        public static void al_ver_hesaplama(float alincakpm,float satilcakpbf,float alincakpbf)
        {
            sonuc = (( satilcakpbf* alincakpm) / alincakpbf);
        }
        //müşteriden alıncak ve verilcek tutarı hesaplama bitiş

        //rapor oluşturma başlangıç
        public static DataSet dset;
        public static DataSet rapordoldur(string sorgu)
        {
            con = new SqlConnection(baglan);
            da = new SqlDataAdapter(sorgu, con);
            dset = new DataSet();
            con.Open();
            da.Fill(dset,sorgu);
           
            con.Close();
            return dset;
           
        }

        //rapor oluşturma bitiş
    }

}


         
       











