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
    public partial class frmKayitDuzenle : Form
    {
        public frmKayitDuzenle()
        {
            InitializeComponent();
        }

        //Veritabanı bağlantı connection stringimi oluşturuyorum
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + ("/OgrenciOtomasyonu.accdb"));
        //hem metodumda hem de formun load olayında kullanacağım için global olarak dataset nesnemi de oluşturuyorum adını dt verdim.
        DataSet dt = new DataSet();

        public void VerileriListele()
        {
            //bağlantımı açıyorum.
            conn.Open();
            //OgrenciBilgiler tablosundaki tüm kayıtları çekiyorum
            OleDbDataAdapter adt = new OleDbDataAdapter("SELECT * FROM OgrenciBilgiler", conn);
            //Bir dataset oluşturuyorum ve bu dataset nesnemi tablom ile dolduruyorum, dataset nesnemin adını dt verdim, tablomun adı da OgrenciBilgiler olsun.
            adt.Fill(dt, "OgrenciBilgiler");
            //DataGridView kontrolümün DataMember özelliği ile OgrenciBilgiler tablomu eşitliyorum
            dataGridView1.DataMember = "OgrenciBilgiler";
            //DataGridView kontrolümün DataSource özelliğini de dt nesnesine eşitliyorum
            dataGridView1.DataSource = dt;
            //Bağlantımı kapatıyor ve adaptörü dispose ediyorum, serbest bırakıyorum.
            adt.Dispose();
            conn.Close();
        }

        private void frmKayitDuzenle_Load(object sender, EventArgs e)
        {
            //Verileri Listeleme metodumu çalıştırıyorum
            VerileriListele();
            //OgrenciBilgiler tablosundaki verileri form üzerinde yer alan ilgili kontrollerde görüntüleyeceğim, bunun için DataBinding kullanıyorum.
            msktxtTCKimlikNo.DataBindings.Add("Text", dt, "OgrenciBilgiler.TC_Kimlik_No");
            txtAdSoyad.DataBindings.Add("Text", dt, "OgrenciBilgiler.AdSoyad");
            msktxtTelefon.DataBindings.Add("Text", dt, "OgrenciBilgiler.Telefon");
            cmbBolum.DataBindings.Add("Text", dt, "OgrenciBilgiler.Bolum");
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //bağlantımı açıyorum
            conn.Open();
            //İlgili alanları güncelleyeceğim, bunun için UPDATE komutunu kullanıyorum.
            OleDbCommand cmd = new OleDbCommand("UPDATE OgrenciBilgiler SET AdSoyad='" + txtAdSoyad.Text + "', Telefon='" + msktxtTelefon.Text + "', Bolum='" + cmbBolum.Text + "' WHERE TC_Kimlik_No='" + msktxtTCKimlikNo.Text + "'", conn);
            cmd.ExecuteNonQuery();
            //Kayıtların güncellendiğini kullanıcıya bildir.
            MessageBox.Show("Veri güncelleme işlemi tamamlanmıştır", "Veri Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //sorguyu dispose edip serbest bırakıyorum
            cmd.Dispose();
            //bağlantımı kapatıyorum
            conn.Close();
            // Tablomun satırlarını temizliyorum
            dt.Clear();
            //En son güncelleme ile birlikte yeni verileri listeliyorum
            VerileriListele();
        }
    }
}
