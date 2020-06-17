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
    public partial class FrmAdmin : Form
    {
        SqlConnection baglanti;
        SqlCommand komut, komut2;
        public FrmAdmin()
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
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            VerileriGoster("Select * From Admin");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into Admin (YöneticiAd,YöneticiParola) values (@y,@p)", baglanti);

            komut.Parameters.AddWithValue("@y", TxtYAd.Text);
            komut.Parameters.AddWithValue("@p", TxtParola.Text);
            komut.ExecuteNonQuery();
            VerileriGoster("Select * From Admin");
            baglanti.Close();
            TxtYAd.Clear();
            TxtParola.Clear();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from Admin where YöneticiAd=@y", baglanti);
            komut.Parameters.AddWithValue("@y", TxtYAd.Text);
            komut.ExecuteNonQuery();
            VerileriGoster("Select * From Admin");
            baglanti.Close();
            TxtYAd.Clear();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {


            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Admin Set YöneticiAd=@y,YöneticiParola=@pp Where Yöneticiid=@id", baglanti);
                komut.Parameters.AddWithValue("@y", TxtYAd.Text);
                komut.Parameters.AddWithValue("@pp", TxtParola.Text);
                komut.Parameters.AddWithValue("@id", TxtYId.Text);
                komut.ExecuteNonQuery();
                VerileriGoster("Select * From Admin");
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
