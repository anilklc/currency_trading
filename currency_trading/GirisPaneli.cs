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
    public partial class GirisPaneli : Form
    { int sayac=0;
        public GirisPaneli()
        {
            InitializeComponent();
        }

        private void GirisPaneli_Load(object sender, EventArgs e)
        {
            veritabani.baglantikontrol();
        }

       

        private void giris_btn_Click(object sender, EventArgs e)
        { 
            veritabani.giris_kontrol(kadi_txt.Text, sifre_txt.Text);
            if (veritabani.yetki=="False")
            {
                kadi_txt.Text = "";
                sifre_txt.Text = "";
                kadi_txt.Focus();
                sayac++;
                if (sayac==3)
                {
                    MessageBox.Show("3 Defa Hatlı Giriş Yaptınız\nLutfen Yöneticinize Başvurunuz");
                    Application.Exit();
                }
            }

        }
    }
}
