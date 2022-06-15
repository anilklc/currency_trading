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
    public partial class ParaEkle_Cikar : Form
    {
        public ParaEkle_Cikar()
        {
            InitializeComponent();
            PE_suankiMiktar_txt.Enabled = false;
            PC_suankiMiktar_txt.Enabled = false;
            veritabani.cmb_xmlAktar(PBE_parabirimi_cmb,1);
            veritabani.cmb_xmlAktar(PBE_parakodu_cmb,10);
            veritabani.cmb_Aktar(PBC_parabirimi_cmb, "select * from Tbl_kasa", "doviz_birimi",0);
            veritabani.cmb_Aktar(PE_parabirimi_cmb, "select * from Tbl_kasa", "doviz_birimi",0);
            veritabani.cmb_Aktar(PC_parabirimi_cmb, "select * from Tbl_kasa", "doviz_birimi",0);
            
        }

        private void paraEkle_btn_Click(object sender, EventArgs e)
        {
            if (PE_eklencilcekMiktar_txt.Text!="")
            {
                veritabani.paraEkle(PE_parabirimi_cmb.Text, PE_eklencilcekMiktar_txt.Text);
                MessageBox.Show("Para Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen Eklencek Miktari Giriniz");
            }
           
        }

        private void paraCikar_btn_Click(object sender, EventArgs e)
        {
            if (PC_cikarilcakMiktar_txt.Text!="")
            {
                veritabani.paraCikar(PC_parabirimi_cmb.Text, PC_cikarilcakMiktar_txt.Text);
                MessageBox.Show("Para Başarıyla Silindi");
            }
            else
            {
                MessageBox.Show("Lütfen Silincek Miktari Giriniz");
            }
        }

        private void paraBirimiEkle_btn_Click(object sender, EventArgs e)
        {
            veritabani.paraBirimiEkle(PBE_parabirimi_cmb.Text,PBE_parakodu_cmb.Text,PBE_eklencilcekMiktar_txt.Text);
        }

        private void paraBirimiCikar_btn_Click(object sender, EventArgs e)
        {
            veritabani.paraBirimiCikar(PBE_parabirimi_cmb.Text);
        }

        private void PBE_parabirimi_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            PBE_parakodu_cmb.SelectedIndex= PBE_parabirimi_cmb.SelectedIndex;
        }

        private void PBE_parakodu_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PBE_parabirimi_cmb.SelectedIndex = PBE_parakodu_cmb.SelectedIndex;
        }

        private void PE_parabirimi_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            veritabani.toplamtutar_Aktar(PE_parabirimi_cmb.Text);
            PE_suankiMiktar_txt.Text=veritabani.toplamtutarAktar;
        }

        private void PC_parabirimi_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            veritabani.toplamtutar_Aktar(PC_parabirimi_cmb.Text);
            PC_suankiMiktar_txt.Text = veritabani.toplamtutarAktar;
        }

        private void PE_eklencilcekMiktar_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
