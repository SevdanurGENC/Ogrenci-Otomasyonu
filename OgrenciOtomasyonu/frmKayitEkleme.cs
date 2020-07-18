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
    public partial class frmKayitEkleme : Form
    {
        public frmKayitEkleme()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Herhangi bir TC Kimlik Numarası girilmiş mi girilmemiş mi kontrol ediyorum.
            if (msktxtTCKimlikNo.Text != "")
            {
                //Aşağıdaki satır ile veritabanı bağlantımı gerçekleştiriyorumç
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + ("/OgrenciOtomasyonu.accdb"));
                //Bağlantımı açıyorum.
                conn.Open();

                //Daha önceden aynı TC kimlik numarası veri tabanımda var mı yok mu bunu öğrenmek için önce sorgumu yazıyorum.
                //oledbcommand komutu veritabanı ile ilgili sorguları çalıştırmak için kullanılır.
                OleDbCommand TCKimlikVarmiYokmu = new OleDbCommand("SELECT * FROM OgrenciBilgiler WHERE TC_Kimlik_No=" + "'" + msktxtTCKimlikNo.Text + "'", conn);
                OleDbDataReader dr = TCKimlikVarmiYokmu.ExecuteReader();


                //Gelen tüm satırları kontrol ediyorum. Burada Read ile okuma işlemini OleDbDataReader nesnesi üzerinden yapıyorum.
                if (dr.Read())
                {
                    //Daha önceden kayıtlı aynı YC kimlik no var ise kullanıcıyı uyarıyorum.
                    MessageBox.Show("Daha önce kaydedilmiş TC kimlik numarası girdiniz." , "Öğrenci Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // ilgili alanları sıfırlıyorum.
                    txtAdSoyad.Text="";
                    msktxtTCKimlikNo.Text="";
                }

                    //Eğer TC Kimlik no ilk defa giriliyor yani hiç bi sorun yoksa artık else bloğum çalışıyor.

                else
                {
                    //Burada da öncelikle yeni bir kayıt eklemek için OgrenciKayitEkle nesnemi oluşturdum. Insert Into komutu veritabanına veri eklemek için kullanılır. 
                    OleDbCommand OgrenciKayitEkle = new OleDbCommand("INSERT INTO OgrenciBilgiler (TC_Kimlik_No,AdSoyad,DogumTarihi,Telefon,Bolum) VALUES("+ msktxtTCKimlikNo.Text + ",'" + txtAdSoyad.Text + "','" + dtpDogumTarihi.Value + "','" + msktxtTelefonNo.Text + "','" + cmbBolum.Text + "')", conn);
                    //ExecuteNonQuery oluşturulan veritabanı deyimini çalıştırarak etkilenen satır sayınısı döner. Yani ekleme, silme, güncelleme sonucu etkilenen satır sayısı.
                    OgrenciKayitEkle.ExecuteNonQuery();

                    //Kayıt işleminin gerçekleştiğini kullanıcıya bildiriyorum.
                    MessageBox.Show("Kayıt işlemi gerçekleştirilmiştir.", "Öğrenci Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //olşuturulan sorguyu dispose ile serbest bırakıyoruz
                    OgrenciKayitEkle.Dispose();
                    //veritabanı bağlantımı kapatıyorum.
                    conn.Close();
                }
            }
             else
                MessageBox.Show("Lütfen TC Kimlik numarası giriniz", "TC Kimlik Numarası Alanı Boş!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
           
    }
}
