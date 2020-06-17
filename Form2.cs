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
    public partial class Form2 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;

        public Form2()
        {
            InitializeComponent();
        }
     

        public void VerileriGoster(string veriler)

        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");

        }

        private void PcbListele_Click(object sender, EventArgs e)
        {
            VerileriGoster("Select * From Bolumler");
        }

        private void PcbEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut= new SqlCommand("insert into Bolumler (BolumAdi) values (@pBolumAdi)",baglanti);
          
            komut.Parameters.AddWithValue("@pBolumAdi", TxtBolumAdi.Text);
            komut.ExecuteNonQuery();
            VerileriGoster("Select * From Bolumler");
            baglanti.Close();
            TxtBolumAdi.Clear();

        }

        private void PcbSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from Bolumler where BolumAdi=@pBolumAdi", baglanti);
            komut.Parameters.AddWithValue("@pBolumAdi", TxtBolumAdi.Text);
            komut.ExecuteNonQuery();
            VerileriGoster("Select * From Bolumler");
            baglanti.Close();
            TxtBolumAdi.Clear();

        }
        //Arama İşlemi
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Select* from Bolumler Where BolumAdi like '%"+TxtBolumAdi.Text+ "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
          
            baglanti.Close();
           TxtBolumAdi.Clear();
        }

        private void PcbGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Bolumler Set BolumAdi=@p1 Where Bolumid=@p2", baglanti);
                komut.Parameters.AddWithValue("@p2", TxtBolumid.Text);
                komut.Parameters.AddWithValue("@p1", TxtBolumAdi.Text);
                komut.ExecuteNonQuery();
                VerileriGoster("Select * From Bolumler");
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
