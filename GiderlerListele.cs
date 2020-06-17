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
    public partial class GiderlerListele : Form
    {
        SqlConnection baglanti;
       
        public GiderlerListele()
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
        private void GiderlerListele_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster("Select * From Giderler");
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            GiderlerGüncelleme gg = new GiderlerGüncelleme();

            gg.Odemeid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            gg.Elektrik= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gg.Su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            gg.Dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            gg.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            gg.Gıda = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            gg.Personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            gg.Diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
          
            gg.Show();
        }
    }
}
