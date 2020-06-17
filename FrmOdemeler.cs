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
    public partial class FrmOdemeler : Form
    {
        SqlConnection baglanti;
        SqlCommand komut,komut2;
        public FrmOdemeler()
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
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster("Select * From Borclar");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
           kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtOgrAdi.Text = ad;
            TxtOgrSoyad.Text = soyad;
            TxtKalanBorc.Text = kalan;
            TxtOgrId.Text = id;




        }

        private void OdemeAl_Click(object sender, EventArgs e)
        {
            //Kalan Borcun Hesaplanması
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalanBorc.Text);
            yeniborc = kalan - odenen;
            TxtKalanBorc.Text = yeniborc.ToString();

            //Veritabanından kalan borcun güncellenmesi

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Borclar Set OgrKalanBorc=@p1 Where Ogrid=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKalanBorc.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgrId.Text);
            komut.ExecuteNonQuery();
            VerileriGoster("Select * From Borclar");
            baglanti.Close();
            MessageBox.Show("Borç Ödendi");

            //Kasa Tablosuna Ekleme Yapma
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Insert Into Kasa(OdemeAy,OdemeMiktari) Values(@k1,@k2)", baglanti);
            komut2.Parameters.AddWithValue("@k1", TxtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
