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
    public partial class AnlikKurlar : Form
    {
        public AnlikKurlar()
        {
            InitializeComponent();
            veritabani.xmlAktar(xmldtg);
            xmldtg.Columns[2].Visible = false;
            xmldtg.Columns[5].Visible = false;
            xmldtg.Columns[6].Visible = false;
            xmldtg.Columns[7].Visible = false;
            xmldtg.Columns[8].Visible = false;
            xmldtg.Columns[9].Visible = false;
            xmldtg.Columns[11].Visible = false;

            xmldtg.Columns[0].HeaderText = "Birim";
            xmldtg.Columns[1].HeaderText = "Doviz Cinsi";
            xmldtg.Columns[3].HeaderText = "Döviz Alış";
            xmldtg.Columns[4].HeaderText = "Döviz Satış";
            xmldtg.Columns[10].HeaderText = "Döviz Kodu";

            xmldtg.Columns[0].Width = 50;
            xmldtg.Columns[1].Width = 300;
            xmldtg.Columns[3].Width = 135;
            xmldtg.Columns[4].Width = 135;
            xmldtg.Columns[10].Width = 130;
        }

        private void yenile_btn_Click(object sender, EventArgs e)
        {
            veritabani.xmlAktar(xmldtg);
        }

       
    }
}
