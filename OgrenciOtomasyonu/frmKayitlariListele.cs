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
    public partial class frmKayitlariListele : Form
    {
        public frmKayitlariListele()
        {
            InitializeComponent();
        }

        private void frmKayitlariListele_Load(object sender, EventArgs e)
        {
            //Veritabanı bağlantı connection stringimi oluşturuyorum
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + ("/OgrenciOtomasyonu.accdb"));
            
            //Dataset nesnemi oluşturuyorum adını dt verdim.
            DataSet dt = new DataSet();
            
            //Bağlantımı açıyorum
            conn.Open();
            
            //adt adında bir OleDbAdapter nesnesi oluşturuyorum
            OleDbDataAdapter adt = new OleDbDataAdapter("SELECT OgrenciBilgiler.TC_Kimlik_No, OgrenciBilgiler.AdSoyad, OgrenciNotlar.Vize, OgrenciNotlar.Final, OgrenciNotlar.Ortalama FROM OgrenciBilgiler, OgrenciNotlar WHERE OgrenciBilgiler.TC_Kimlik_No = OgrenciNotlar.TC_Kimlik_No", conn);
           
            //Dt isimli DataSet'imi OgrenciBilgiler tablom ile dolduruyorum.
            adt.Fill(dt, "OgrenciBilgiler");
           
            //DataGridView kontrolümün DataMember özelliğini tabloma eşitliyorum.
            dataGridView1.DataMember = "OgrenciBilgiler";
           
            //DataGridView kontrolümün DataSource nesnesini dataset nesneme eşitliyorum.
            dataGridView1.DataSource = dt;
            
            //adt'i dispose ediyorum ve bağlantımı kapatıyorum
            adt.Dispose();
            conn.Close();
        }
    }
}
