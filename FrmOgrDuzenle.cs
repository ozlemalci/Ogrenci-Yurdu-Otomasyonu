using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmOgrDuzenle : Form
    {
        SqlConnection baglanti;
        
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        

        public string id;
        public string OgrAd;
        public string OgrSoyad;
        public string OgrTC;
        public string OgrTelefon;
        public string OgrDogum;
        public string OgrBolum;
        public string OgrMail;
        public string OgrOdaNo;
        public string VeliAdSoyad;
        public string VeliTelefon;
        public string VeliAdres;

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");
            TxtOgrid.Text = id;
            TxtOgrAd.Text = OgrAd;
            TxtOgrSoyad.Text = OgrSoyad;
            MskTC.Text = OgrTC;
            MskOgrTelefon.Text = OgrTelefon;
            MskDogTarihi.Text = OgrDogum;
            CBoxOgrBolum.Text = OgrBolum;
            TxtOgrMail.Text = OgrMail;
            MskVeliTelefon.Text = VeliTelefon;
            CBoxOdaNo.Text = OgrOdaNo;
            TxtVeliAdSoyad.Text = VeliAdSoyad;
            RichAdres.Text = VeliAdres;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Ogrenci Set OgrAd=@p1,OgrSoyad=@p2,OgrTC=@p3,OgrTelefon=@p4, OgrDogum=@p5,OgrBolum=@p6,OgrMail=@p7 ,OgrOdaNo=@p8,OgrVeliAdSoyad=@p9,OgrVeliTelefon=@p10,OgrVeliAdres=@p11 Where Ogrid=@p12", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTC.Text);
                komut.Parameters.AddWithValue("@p4",MskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p5", MskDogTarihi.Text);
                komut.Parameters.AddWithValue("@p6", CBoxOgrBolum.Text);
                komut.Parameters.AddWithValue("@p7", TxtOgrMail.Text);
                komut.Parameters.AddWithValue("@p8", CBoxOdaNo.Text);
                komut.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p10", MskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p11", RichAdres.Text);
                komut.Parameters.AddWithValue("@p12", TxtOgrid.Text);


                komut.ExecuteNonQuery();
               
                baglanti.Close();
                MessageBox.Show("Güncelleme Gerçekleşti..");
            }
            catch
            {
                MessageBox.Show("Hataa!!");

            }

        }

        private void BtnOgrSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oğrenci where Ogrid=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtOgrid.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi!!");
            }
            catch
            {
                MessageBox.Show("HATA!!");
            }

         
        }
    }
}
