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
    public partial class FrmOgrenciler : Form
    {  

        SqlConnection baglanti;
        SqlCommand komut;
    
        public FrmOgrenciler()
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster("Select * From Ogrenci");
        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.OgrAd= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.OgrSoyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.OgrTC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.OgrTelefon= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.OgrDogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.OgrBolum= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.OgrMail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.OgrOdaNo= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.VeliAdSoyad= dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.VeliTelefon= dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.VeliAdres= dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            fr.Show();
        }
    }
}
