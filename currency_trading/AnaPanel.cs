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
    public partial class AnaPanel : Form
    {
        public AnaPanel()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToLongDateString();
          
            yonetici_menu();
            timer1.Start();
            

        }
        private void yonetici_menu()
        {
            if (veritabani.yetki=="True")
            {
               gecmisIslemler_btn.Visible = true;
                calisan_ekle_btn.Visible = true;
               paraekle_btn.Visible = true;
            }
           else
            {
                gecmisIslemler_btn.Visible = false;
                calisan_ekle_btn.Visible = false;
                paraekle_btn.Visible = false;
            }

        }

        private Form frm = null;
        private void acilacakform_fonk(Form acilcakform)
        {
            if (frm != null)
                frm.Close();
            frm = acilcakform;
            acilcakform.TopLevel = false;
            acilcakform.FormBorderStyle = FormBorderStyle.None;
            acilcakform.Dock = DockStyle.Fill;
           panel3.Controls.Add(acilcakform);
            panel3.Tag = acilcakform;
            acilcakform.BringToFront();
            acilcakform.Show();
        }
        
        

        

        private void calisan_ekle_btn_Click(object sender, EventArgs e)
        {
            acilacakform_fonk(new KullanıcıOlustur());
        }

       

        private void duyurular_btn_Click(object sender, EventArgs e)
        {
            acilacakform_fonk(new Duyurular());

        }

        private void istatistik_btn_Click_1(object sender, EventArgs e)
        {
            acilacakform_fonk(new Istatistikler());
        }




      
        private void gecmisIslemler_btn_Click_1(object sender, EventArgs e)
        {
            acilacakform_fonk(new GecmisIslemler());
        }

        

        private void hesapayarlari_btn_Click(object sender, EventArgs e)
        {
            acilacakform_fonk(new KullanıcıDuzenle());
        }

        private void paraekle_btn_Click(object sender, EventArgs e)
        {
            acilacakform_fonk(new ParaEkle_Cikar());
        }

        private void cikis_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToLongDateString();
            saat.Text = DateTime.Now.ToLongTimeString();
        }

        private void anlikKurlar__btn_Click(object sender, EventArgs e)
        {
            acilacakform_fonk(new AnlikKurlar());
        }

        private void alsat_btn_Click(object sender, EventArgs e)
        {
            acilacakform_fonk(new Alım_Satım());
        }
    }
}
