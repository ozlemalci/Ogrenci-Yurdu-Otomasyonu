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
using System.Data.Sql;


namespace YurtKayitSistemi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlCommand komut2;
        SqlCommand komutKaydet;
        SqlDataReader oku;
        SqlDataReader oku2;
        SqlCommand komut3;
        SqlDataReader oku3;
        SqlCommand komutKaydet2,komutoda;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");
            baglanti.Open();
            komut = new SqlCommand("Select BolumAdi From Bolumler", baglanti);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CBoxOgrBolum.Items.Add(oku[0].ToString());


            }

            baglanti.Close();
            //Boş Odaları Listeleme İşlemi

            baglanti.Open();
            komut2 = new SqlCommand("Select OdaNo From Odalar  Where OdaKapasite != OdaAktif", baglanti);
            oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CBoxOdaNo.Items.Add(oku2[0].ToString());
            }

            baglanti.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtOgrBolum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();

                komutKaydet = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", baglanti);
                
                komutKaydet.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                komutKaydet.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p4", MskTC.Text);
                komutKaydet.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@p6", MskDogTarihi.Text);
                komutKaydet.Parameters.AddWithValue("@p7", CBoxOgrBolum.Text);
                komutKaydet.Parameters.AddWithValue("@p8", TxtOgrMail.Text);
                komutKaydet.Parameters.AddWithValue("@p9", CBoxOdaNo.Text);
                komutKaydet.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@p12", RichAdres.Text);

                komutKaydet.ExecuteNonQuery();
               
                MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleştirildi.");

                //Öğrenci id'yi labela çekme

                /*
                SqlCommand komut = new SqlCommand("select Ogrid From Ogrenci",baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text=oku[0].ToString();
                }

                baglanti.Close();

                MessageBox.Show("HATA deneme");
                */
                //Öğrenci Borç Alana Oluşturma

                SqlCommand komutKaydet2 = new SqlCommand("insert into Borclar  (Ogrid,OgrAd,OgrSoyad) values(@b1,@b2,@b3) ", baglanti);
                komutKaydet2.Parameters.AddWithValue("@b1", TxtOgrid.Text);
                komutKaydet2.Parameters.AddWithValue("@b2", TxtOgrAd.Text);
                komutKaydet2.Parameters.AddWithValue("@b3", TxtOgrSoyad.Text);
                komutKaydet2.ExecuteNonQuery();
                baglanti.Close();
               
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!LÜTFEN YENİDEN DENEYİN..");

            }

            //Öğrenci oda kontenjanı azaltma

            baglanti.Open();
            SqlCommand komutoda = new SqlCommand("Update Odalar Set OdaAktif=OdaAktif+1 Where OdaNo=@p1", baglanti);
            komutoda.Parameters.AddWithValue("@p1", CBoxOdaNo.Text);
            komutoda.ExecuteNonQuery();
            baglanti.Close();
        }

    }
    }

    


