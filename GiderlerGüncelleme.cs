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
    public partial class GiderlerGüncelleme : Form
    {

        SqlConnection baglanti;

        public GiderlerGüncelleme()
        {
            InitializeComponent();
        }
        public string Odemeid;
        public string Elektrik;
        public string Su;
        public string Dogalgaz;
        public string internet;
        public string Gıda;
        public string Personel;
        public string Diger;
       
        private void GiderlerGüncelleme_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");
            TxtOdemeid.Text = Odemeid;
            TxtElektrik.Text = Elektrik;
            TxtSu.Text = Su;
            TxtDogalgaz.Text = Dogalgaz;
            TxtInternet.Text = internet;
            TxtGıda.Text = Gıda;
            TxtPersonel.Text = Personel;
            TxtDiger.Text = Diger;
           
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Giderler Set Elektrik=@p2,Su=@p3,Doğalgaz=@p4,internet=@p5,Gıda=@p6,Personel=@p7,Diger=@p8 Where Odemeid=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtOdemeid.Text);
                komut.Parameters.AddWithValue("@p2", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p3", TxtSu.Text);
                komut.Parameters.AddWithValue("@p4", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p5", TxtInternet.Text);
                komut.Parameters.AddWithValue("@p6", TxtGıda.Text);
                komut.Parameters.AddWithValue("@p7", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p8", TxtDiger.Text);
                

                komut.ExecuteNonQuery();

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
