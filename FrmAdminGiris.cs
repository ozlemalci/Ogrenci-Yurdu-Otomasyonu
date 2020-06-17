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
    public partial class FrmAdminGiris : Form
    {
        SqlConnection baglanti;
        SqlDataReader oku;
        SqlCommand komut;
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=YurtKayıt;Integrated Security=SSPI");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Admin Where YöneticiAd=@p1 and YöneticiParola=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtParola.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                AnaForm frm = new AnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!!");
                TxtKullaniciAdi.Clear();
                TxtParola.Clear();
                TxtKullaniciAdi.Focus();
            }
            baglanti.Close();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                TxtParola.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                TxtParola.PasswordChar = '*';
            }
        }
    }
}
