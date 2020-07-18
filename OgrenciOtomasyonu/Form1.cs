using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OgrenciOtomasyonu
{
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            frmKayitEkleme yeniForm = new frmKayitEkleme();
            yeniForm.Show();
        }

        private void btnNotGir_Click(object sender, EventArgs e)
        {
            frmNotGirisi NotGirisForm = new frmNotGirisi();
            NotGirisForm.ShowDialog();
        }

        private void btnKayitListele_Click(object sender, EventArgs e)
        {
            frmKayitlariListele frm = new frmKayitlariListele();
            frm.Show();
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            frmKayitDuzenle frm = new frmKayitDuzenle();
            frm.Show();
        }
    }
}
