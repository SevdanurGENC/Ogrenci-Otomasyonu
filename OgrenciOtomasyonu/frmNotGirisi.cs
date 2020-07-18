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
    public partial class frmNotGirisi : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + ("/OgrenciOtomasyonu.accdb"));

        public frmNotGirisi()
        {
            InitializeComponent();
        }

       
        private void frmNotGirisi_Load(object sender, EventArgs e)
        {

        }

        private void cmbBolumListe_TextChanged(object sender, EventArgs e)
        {
            //Aşağıdaki satır ile veritabanı bağlantımı gerçekleştiriyorumç
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + ("/OgrenciOtomasyonu.accdb"));
            //Bağlantımı açıyorum.
            conn.Open();

            //OgrenciBilgiler tablosunda seçilen bölüm altında kayıtlı olan ama Notlar tablosunda kaydı bulunmayan TC Kimlik numaralarını veri tabanından okuyorum.
            OleDbCommand query = new OleDbCommand("SELECT TC_Kimlik_No, Bolum FROM OgrenciBilgiler WHERE TC_Kimlik_No NOT IN (SELECT TC_Kimlik_No FROM OgrenciNotlar) AND Bolum=" + "'" + cmbBolumListe.Text + "'", conn);
            //Üstteki sorgum sonucu gelen verileri aşağıdaki OleDbDataReader nesnesi ile okuyorum.
            OleDbDataReader dr = query.ExecuteReader();

            while (dr.Read())
            {
                //Sorgum sonucu elde ettiğim TC Kimlik numaralarını  TC Kimlik No Combobox kontrolüme ekliyorum.
                cmbTCKimlikNoListe.Items.Add(dr["TC_Kimlik_No"]);
            }

            dr.Close();
            //Sorguyu serbest bırakıyorum
            query.Dispose();
            //Bağlantımı kapatıyorum
            conn.Close();
        }

        private void cmbBolumListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTCKimlikNoListe_TextChanged(object sender, EventArgs e)
        {
            //Bağlantımı açıyorum, ama bu sefer bağlantı oluşturma connection stringimi yukarıda ayrıca yazdım.
            conn.Open();

            //Combobox üzerinden seçilen TC Kimlik Numarasına göre kayda karşılık gelen ad ve soyad bilgisini OgrenciBilgiler tablosundan çekeceğiz.
            OleDbCommand query = new OleDbCommand("SELECT AdSoyad FROM OgrenciBilgiler WHERE TC_Kimlik_No = " + "'" + cmbTCKimlikNoListe.Text + "'", conn);
            //Üstteki sorgum sonucu gelen verileri aşağıdaki OleDbDataReader nesnesi ile okuyorum.
            OleDbDataReader dr = query.ExecuteReader();
            if (dr.Read())
            {
                //Sorgudan elde edilen ad ve soyad bilgilerini ilgili labela yazıyorum.
                lblAdSoyad.Text = dr["AdSoyad"].ToString();
            }
            //Sorguyu serbest bırakıyorum
            query.Dispose();
            //Bağlantı kapatıyorum
            conn.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Değişkenlerimi tanımladım.
            int VizeNotu, FinalNotu;
            //Ortalamam kesirli bir sayı çıkabilir, dolayısı ile float olarak tanımladım.
            float Ortalama;
            //vize ve/veya final notlarının boş geçilmesi durumunda kullanıcıy uyarıyorum, işlem yapmıyorum.
            if (msktxtVize.Text == "" || msktxtFinal.Text == "")
            {
                MessageBox.Show("Vize notu ve/veya final notu alanları boş geçilemez! Lütfen ilgili alanları doldurunuz.");
            }
                //Bir problem yoksa aşağıdan devam ediyorum.
            else
            {
                //Masked textboxlardaki veriler string tipinde dolayısı ile bunların integer yapıyorum ki üzerinde işlem yapabileyim.
                VizeNotu = Convert.ToInt32(msktxtVize.Text);
                FinalNotu = Convert.ToInt32(msktxtFinal.Text);
                //Eğer bu girilen notlardan vize ve/veya final notu 100'den fazla girildi ise kullanıcıyı tekrar uyarıyorum.
                if (VizeNotu > 100 || FinalNotu > 100)
                {
                    MessageBox.Show("Vize notu ve/veya final notu 100'den fazla olamaz! Gerekli düzenlemeyi yapınız");
                }
                    //Notlarda sorun yok ise aşağıdaki kodlarla devam ediyorum.
                else
                {
                    //Ortalamamı hesaplıyorum, bulduğum sonucu ilgili labela yazıyorum.
                    Ortalama = (VizeNotu * 0.3F) + (FinalNotu * 0.7F);
                    lblOrtalama.Text = Ortalama.ToString();
                    //Bağlantımı açıyorum. Daha önceden bu connection stringimi yazmıştım, buna dikkat edin.
                    conn.Open();
                    //OleDbCommand nesnem üzerinden yeni bir sınıf oluşturarak form üzerindeki verileri vertabanıma aktarıyorum. 
                    OleDbCommand NotKaydet = new OleDbCommand("INSERT INTO OgrenciNotlar (TC_Kimlik_No, Vize, Final, Ortalama) VALUES('" + cmbTCKimlikNoListe.Text + "','" + msktxtVize.Text + "','" + msktxtFinal.Text + "','" + lblOrtalama.Text + "')",conn);
                    NotKaydet.ExecuteNonQuery();
                    //veri aktarma işleminin tamamlandığını kullanıcıya bildiriyorum.
                    MessageBox.Show("Notlar veritabanına aktarılmıştır","Not Ekleme",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Sınıfı serbest bırakıyorum, bağlantımı kapatıyorum.
                    NotKaydet.Dispose();
                    conn.Close();
                    //İlgili alanları sıfırlıyorum.
                    cmbTCKimlikNoListe.Items.RemoveAt(cmbTCKimlikNoListe.SelectedIndex);
                    msktxtFinal.Text = "";
                    msktxtVize.Text = "";
                    lblOrtalama.Text = "";
                    lblAdSoyad.Text = "";
                }

            }
        }
    }
}
