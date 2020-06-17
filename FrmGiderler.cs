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
    public partial class FrmGiderler : Form
    {
        SqlConnection baglanti;
        SqlCommand komutKaydet;
        public FrmGiderler()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            komutKaydet = new SqlCommand("insert into Giderler(Elektrik,Su,Doğalgaz,internet,Gıda,Personel,Diger) values (@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);

            komutKaydet.Parameters.AddWithValue("@p2", TxtElektrik.Text);
            komutKaydet.Parameters.AddWithValue("@p3", TxtSu.Text);
            komutKaydet.Parameters.AddWithValue("@p4", TxtDogalgaz.Text);
            komutKaydet.Parameters.AddWithValue("@p5", TxtInternet.Text);
            komutKaydet.Parameters.AddWithValue("@p6", TxtGıda.Text);
            komutKaydet.Parameters.AddWithValue("@p7", TxtPersonel.Text);
            komutKaydet.Parameters.AddWithValue("@p8", TxtDiger.Text);
           
            komutKaydet.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleştirildi.");
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");
           
        }
    }
}
