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
    public partial class FrmGelirIstatistik : Form

    {
        SqlConnection baglanti;
        SqlCommand komut,komut2,komut3;
        SqlDataReader oku,oku2,oku3;

        private void CmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Select Sum(OdemeMiktari)  From Kasa Where OdemeAy=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", CmbAy.Text);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblSecilenAy.Text = oku[0].ToString()+ "TL";

            }
            baglanti.Close();

        }

        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }

        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {

            //Kasadaki Toplam Para
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");
            baglanti.Open();
            komut = new SqlCommand("Select Sum(OdemeMiktari) From Kasa", baglanti);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblPara.Text = oku[0].ToString()+ "TL";
            }
            baglanti.Close();
            //Ayların tekrarsız listelenmesi
            baglanti.Open();
            komut2 = new SqlCommand("Select Distinct(OdemeAy) From Kasa", baglanti);
            oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbAy.Items.Add(oku2[0].ToString());
            }
            baglanti.Close();
            //Veritabanında veri çekme grafiklere
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select  OdemeAy,sum(OdemeMiktari) from Kasa Group by OdemeAy", baglanti);
            oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            baglanti.Close();
        }
    }
}
