using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace YurtKayitSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void PcbHesapMakinesş_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmOgrenciler fö = new FrmOgrenciler();
            fö.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 fb = new Form2();
            fb.Show();

        }

        private void PcbÖdemeler_Click(object sender, EventArgs e)
        {
            FrmOdemeler fro = new FrmOdemeler();
            fro.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmGiderler fg = new FrmGiderler();
            fg.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GiderlerListele gl = new GiderlerListele();
            gl.Show();

        }

        private void Pcbİstatistik_Click(object sender, EventArgs e)
        {
            FrmGelirIstatistik fi = new FrmGelirIstatistik();
            fi.Show();
        }

        private void PcbYöneticiAyarları_Click(object sender, EventArgs e)
        {
            FrmAdmin fa = new FrmAdmin();
            fa.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPersonel fp = new FrmPersonel();
            fp.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
