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
    public partial class FrmPersonel : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;

        public FrmPersonel()
        {
            InitializeComponent();
        }
        public void VerileriGoster(string veriler)

        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            VerileriGoster("Select * From Personel");
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)", baglanti);

            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtDepartman.Text);
            komut.ExecuteNonQuery();
            VerileriGoster("Select * From Personel");
            baglanti.Close();
           
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from Personel where PersonelAdSoyad=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.ExecuteNonQuery();
            VerileriGoster("Select * From Personel");
            baglanti.Close();
         

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Personel Set PersonelAdSoyad=@p1,PersonelDepartman=@p2 Where Personelid=@p3", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtDepartman.Text);
                komut.Parameters.AddWithValue("@p3", TxtPersonelid.Text);
                komut.ExecuteNonQuery();
                VerileriGoster("Select * From Personel");
                baglanti.Close();
                MessageBox.Show("Güncelleme Gerçekleşti..");
            }
            catch
            {
                MessageBox.Show("Hataa!!");

            }
        }
    }
}
