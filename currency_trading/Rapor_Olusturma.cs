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
    public partial class Rapor_Olusturma : Form
    {
        public Rapor_Olusturma()
        {
            InitializeComponent();
        }
        public string sorgu,tur;
        private void Yazdir_Load(object sender, EventArgs e)
        {

            veritabani.rapordoldur(sorgu);
            
            RaporIslemler1.SetDataSource(veritabani.dset.Tables[sorgu]);
            RaporIslemler1.SetParameterValue("cikarilantur",tur);
            crystalReportViewer1.ReportSource = RaporIslemler1;
        }
    }
}
