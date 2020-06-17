namespace YurtKayitSistemi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.PcbEkle = new System.Windows.Forms.PictureBox();
            this.PcbSil = new System.Windows.Forms.PictureBox();
            this.PcbGuncelle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBolumid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBolumAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PcbListele = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcbEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbEkle
            // 
            this.PcbEkle.Image = ((System.Drawing.Image)(resources.GetObject("PcbEkle.Image")));
            this.PcbEkle.Location = new System.Drawing.Point(137, 147);
            this.PcbEkle.Name = "PcbEkle";
            this.PcbEkle.Size = new System.Drawing.Size(94, 53);
            this.PcbEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbEkle.TabIndex = 0;
            this.PcbEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbEkle, "Ekle");
            this.PcbEkle.Click += new System.EventHandler(this.PcbEkle_Click);
            // 
            // PcbSil
            // 
            this.PcbSil.Image = ((System.Drawing.Image)(resources.GetObject("PcbSil.Image")));
            this.PcbSil.Location = new System.Drawing.Point(15, 236);
            this.PcbSil.Name = "PcbSil";
            this.PcbSil.Size = new System.Drawing.Size(94, 59);
            this.PcbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbSil.TabIndex = 1;
            this.PcbSil.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbSil, "Sil");
            this.PcbSil.Click += new System.EventHandler(this.PcbSil_Click);
            // 
            // PcbGuncelle
            // 
            this.PcbGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("PcbGuncelle.Image")));
            this.PcbGuncelle.Location = new System.Drawing.Point(137, 236);
            this.PcbGuncelle.Name = "PcbGuncelle";
            this.PcbGuncelle.Size = new System.Drawing.Size(94, 59);
            this.PcbGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbGuncelle.TabIndex = 2;
            this.PcbGuncelle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbGuncelle, "Güncelle");
            this.PcbGuncelle.Click += new System.EventHandler(this.PcbGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm Id : \r\n";
            // 
            // TxtBolumid
            // 
            this.TxtBolumid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumid.Location = new System.Drawing.Point(104, 35);
            this.TxtBolumid.Name = "TxtBolumid";
            this.TxtBolumid.Size = new System.Drawing.Size(414, 26);
            this.TxtBolumid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Adı : \r\n";
            // 
            // TxtBolumAdi
            // 
            this.TxtBolumAdi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumAdi.Location = new System.Drawing.Point(104, 94);
            this.TxtBolumAdi.Name = "TxtBolumAdi";
            this.TxtBolumAdi.Size = new System.Drawing.Size(414, 26);
            this.TxtBolumAdi.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(255, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(263, 240);
            this.dataGridView1.TabIndex = 7;
            // 
            // PcbListele
            // 
            this.PcbListele.Image = ((System.Drawing.Image)(resources.GetObject("PcbListele.Image")));
            this.PcbListele.Location = new System.Drawing.Point(15, 147);
            this.PcbListele.Name = "PcbListele";
            this.PcbListele.Size = new System.Drawing.Size(96, 53);
            this.PcbListele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbListele.TabIndex = 8;
            this.PcbListele.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbListele, "Listele");
            this.PcbListele.Click += new System.EventHandler(this.PcbListele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Ara");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(577, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PcbListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBolumAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcbGuncelle);
            this.Controls.Add(this.PcbSil);
            this.Controls.Add(this.PcbEkle);
            this.Name = "Form2";
            this.Text = "Bolumler";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbEkle;
        private System.Windows.Forms.PictureBox PcbSil;
        private System.Windows.Forms.PictureBox PcbGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBolumid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBolumAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox PcbListele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}