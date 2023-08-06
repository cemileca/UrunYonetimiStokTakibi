namespace UrunYonetimiStokTakibi
{
    partial class UrunYonetimFrm
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
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.cbxDurum = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunAciklama = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.dgvUrunYonetim = new System.Windows.Forms.DataGridView();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mArkaYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grBxUrunYonetim = new System.Windows.Forms.GroupBox();
            this.mnStripUrunYonetim = new System.Windows.Forms.MenuStrip();
            this.rTxtUrunAciklamasi = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.lblKDV = new System.Windows.Forms.Label();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.lblStokMiktari = new System.Windows.Forms.Label();
            this.lblAktifPassif = new System.Windows.Forms.Label();
            this.cmbBxUrunKategorisi = new System.Windows.Forms.ComboBox();
            this.lblUrunKategorisi = new System.Windows.Forms.Label();
            this.lblUrunMarkasi = new System.Windows.Forms.Label();
            this.cmbBxUrunMarkasi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunYonetim)).BeginInit();
            this.grBxUrunYonetim.SuspendLayout();
            this.mnStripUrunYonetim.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(208, 748);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(128, 84);
            this.btnKategoriGuncelle.TabIndex = 5;
            this.btnKategoriGuncelle.Text = "Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(381, 748);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(141, 84);
            this.btnKategoriSil.TabIndex = 6;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(33, 748);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(130, 84);
            this.btnKategoriEkle.TabIndex = 4;
            this.btnKategoriEkle.Text = "Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            // 
            // cbxDurum
            // 
            this.cbxDurum.AutoSize = true;
            this.cbxDurum.Location = new System.Drawing.Point(242, 465);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(107, 29);
            this.cbxDurum.TabIndex = 3;
            this.cbxDurum.Text = "Durum";
            this.cbxDurum.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eklenme Tarihi";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(28, 69);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(95, 25);
            this.lblUrunAdi.TabIndex = 5;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // lblUrunAciklama
            // 
            this.lblUrunAciklama.AutoSize = true;
            this.lblUrunAciklama.Location = new System.Drawing.Point(28, 139);
            this.lblUrunAciklama.Name = "lblUrunAciklama";
            this.lblUrunAciklama.Size = new System.Drawing.Size(167, 25);
            this.lblUrunAciklama.TabIndex = 4;
            this.lblUrunAciklama.Text = "Ürün Açıklaması";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(242, 61);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(282, 31);
            this.txtUrunAdi.TabIndex = 0;
            // 
            // dgvUrunYonetim
            // 
            this.dgvUrunYonetim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunYonetim.Location = new System.Drawing.Point(13, 68);
            this.dgvUrunYonetim.Name = "dgvUrunYonetim";
            this.dgvUrunYonetim.RowHeadersWidth = 82;
            this.dgvUrunYonetim.RowTemplate.Height = 33;
            this.dgvUrunYonetim.Size = new System.Drawing.Size(721, 848);
            this.dgvUrunYonetim.TabIndex = 4;
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(83, 40);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            this.kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            this.kullanıcıYönetimiToolStripMenuItem.Size = new System.Drawing.Size(223, 40);
            this.kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            // 
            // ürünYönetimToolStripMenuItem
            // 
            this.ürünYönetimToolStripMenuItem.Name = "ürünYönetimToolStripMenuItem";
            this.ürünYönetimToolStripMenuItem.Size = new System.Drawing.Size(186, 40);
            this.ürünYönetimToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // mArkaYönetimToolStripMenuItem
            // 
            this.mArkaYönetimToolStripMenuItem.Name = "mArkaYönetimToolStripMenuItem";
            this.mArkaYönetimToolStripMenuItem.Size = new System.Drawing.Size(200, 40);
            this.mArkaYönetimToolStripMenuItem.Text = "Marka Yönetimi";
            // 
            // kategoriYönetimToolStripMenuItem
            // 
            this.kategoriYönetimToolStripMenuItem.Name = "kategoriYönetimToolStripMenuItem";
            this.kategoriYönetimToolStripMenuItem.Size = new System.Drawing.Size(223, 40);
            this.kategoriYönetimToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // grBxUrunYonetim
            // 
            this.grBxUrunYonetim.Controls.Add(this.cmbBxUrunMarkasi);
            this.grBxUrunYonetim.Controls.Add(this.cmbBxUrunKategorisi);
            this.grBxUrunYonetim.Controls.Add(this.rTxtUrunAciklamasi);
            this.grBxUrunYonetim.Controls.Add(this.btnKategoriGuncelle);
            this.grBxUrunYonetim.Controls.Add(this.btnKategoriSil);
            this.grBxUrunYonetim.Controls.Add(this.btnKategoriEkle);
            this.grBxUrunYonetim.Controls.Add(this.cbxDurum);
            this.grBxUrunYonetim.Controls.Add(this.label3);
            this.grBxUrunYonetim.Controls.Add(this.lblUrunAdi);
            this.grBxUrunYonetim.Controls.Add(this.lblUrunMarkasi);
            this.grBxUrunYonetim.Controls.Add(this.lblAktifPassif);
            this.grBxUrunYonetim.Controls.Add(this.lblUrunKategorisi);
            this.grBxUrunYonetim.Controls.Add(this.lblStokMiktari);
            this.grBxUrunYonetim.Controls.Add(this.lblKDV);
            this.grBxUrunYonetim.Controls.Add(this.label1);
            this.grBxUrunYonetim.Controls.Add(this.lblUrunAciklama);
            this.grBxUrunYonetim.Controls.Add(this.txtStokMiktari);
            this.grBxUrunYonetim.Controls.Add(this.txtKDV);
            this.grBxUrunYonetim.Controls.Add(this.textBox1);
            this.grBxUrunYonetim.Controls.Add(this.txtUrunAdi);
            this.grBxUrunYonetim.Location = new System.Drawing.Point(756, 68);
            this.grBxUrunYonetim.Name = "grBxUrunYonetim";
            this.grBxUrunYonetim.Size = new System.Drawing.Size(542, 848);
            this.grBxUrunYonetim.TabIndex = 5;
            this.grBxUrunYonetim.TabStop = false;
            this.grBxUrunYonetim.Text = " ";
            // 
            // mnStripUrunYonetim
            // 
            this.mnStripUrunYonetim.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnStripUrunYonetim.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnStripUrunYonetim.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimToolStripMenuItem,
            this.mArkaYönetimToolStripMenuItem,
            this.ürünYönetimToolStripMenuItem,
            this.kullanıcıYönetimiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.mnStripUrunYonetim.Location = new System.Drawing.Point(0, 0);
            this.mnStripUrunYonetim.Name = "mnStripUrunYonetim";
            this.mnStripUrunYonetim.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.mnStripUrunYonetim.Size = new System.Drawing.Size(1328, 48);
            this.mnStripUrunYonetim.TabIndex = 3;
            this.mnStripUrunYonetim.Text = "menuStrip1";
            // 
            // rTxtUrunAciklamasi
            // 
            this.rTxtUrunAciklamasi.Location = new System.Drawing.Point(242, 98);
            this.rTxtUrunAciklamasi.Name = "rTxtUrunAciklamasi";
            this.rTxtUrunAciklamasi.Size = new System.Drawing.Size(282, 96);
            this.rTxtUrunAciklamasi.TabIndex = 7;
            this.rTxtUrunAciklamasi.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Fiyatı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 31);
            this.textBox1.TabIndex = 0;
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(242, 323);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(282, 31);
            this.txtKDV.TabIndex = 0;
            // 
            // lblKDV
            // 
            this.lblKDV.AutoSize = true;
            this.lblKDV.Location = new System.Drawing.Point(28, 329);
            this.lblKDV.Name = "lblKDV";
            this.lblKDV.Size = new System.Drawing.Size(55, 25);
            this.lblKDV.TabIndex = 4;
            this.lblKDV.Text = "KDV";
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(242, 391);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(282, 31);
            this.txtStokMiktari.TabIndex = 0;
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.AutoSize = true;
            this.lblStokMiktari.Location = new System.Drawing.Point(28, 397);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(125, 25);
            this.lblStokMiktari.TabIndex = 4;
            this.lblStokMiktari.Text = "Stok Miktarı";
            // 
            // lblAktifPassif
            // 
            this.lblAktifPassif.AutoSize = true;
            this.lblAktifPassif.Location = new System.Drawing.Point(28, 465);
            this.lblAktifPassif.Name = "lblAktifPassif";
            this.lblAktifPassif.Size = new System.Drawing.Size(131, 25);
            this.lblAktifPassif.TabIndex = 4;
            this.lblAktifPassif.Text = "Aktif / Passif";
            // 
            // cmbBxUrunKategorisi
            // 
            this.cmbBxUrunKategorisi.FormattingEnabled = true;
            this.cmbBxUrunKategorisi.Location = new System.Drawing.Point(242, 514);
            this.cmbBxUrunKategorisi.Name = "cmbBxUrunKategorisi";
            this.cmbBxUrunKategorisi.Size = new System.Drawing.Size(280, 33);
            this.cmbBxUrunKategorisi.TabIndex = 8;
            // 
            // lblUrunKategorisi
            // 
            this.lblUrunKategorisi.AutoSize = true;
            this.lblUrunKategorisi.Location = new System.Drawing.Point(34, 522);
            this.lblUrunKategorisi.Name = "lblUrunKategorisi";
            this.lblUrunKategorisi.Size = new System.Drawing.Size(160, 25);
            this.lblUrunKategorisi.TabIndex = 4;
            this.lblUrunKategorisi.Text = "Ürün Kategorisi";
            // 
            // lblUrunMarkasi
            // 
            this.lblUrunMarkasi.AutoSize = true;
            this.lblUrunMarkasi.Location = new System.Drawing.Point(34, 573);
            this.lblUrunMarkasi.Name = "lblUrunMarkasi";
            this.lblUrunMarkasi.Size = new System.Drawing.Size(140, 25);
            this.lblUrunMarkasi.TabIndex = 4;
            this.lblUrunMarkasi.Text = "Ürün Markası";
            // 
            // cmbBxUrunMarkasi
            // 
            this.cmbBxUrunMarkasi.FormattingEnabled = true;
            this.cmbBxUrunMarkasi.Location = new System.Drawing.Point(242, 565);
            this.cmbBxUrunMarkasi.Name = "cmbBxUrunMarkasi";
            this.cmbBxUrunMarkasi.Size = new System.Drawing.Size(280, 33);
            this.cmbBxUrunMarkasi.TabIndex = 8;
            // 
            // UrunYonetimFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 928);
            this.Controls.Add(this.dgvUrunYonetim);
            this.Controls.Add(this.grBxUrunYonetim);
            this.Controls.Add(this.mnStripUrunYonetim);
            this.Name = "UrunYonetimFrm";
            this.Text = "Ürün Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunYonetim)).EndInit();
            this.grBxUrunYonetim.ResumeLayout(false);
            this.grBxUrunYonetim.PerformLayout();
            this.mnStripUrunYonetim.ResumeLayout(false);
            this.mnStripUrunYonetim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.CheckBox cbxDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunAciklama;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.DataGridView dgvUrunYonetim;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mArkaYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimToolStripMenuItem;
        private System.Windows.Forms.GroupBox grBxUrunYonetim;
        private System.Windows.Forms.MenuStrip mnStripUrunYonetim;
        private System.Windows.Forms.RichTextBox rTxtUrunAciklamasi;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.Label lblKDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbBxUrunMarkasi;
        private System.Windows.Forms.ComboBox cmbBxUrunKategorisi;
        private System.Windows.Forms.Label lblUrunMarkasi;
        private System.Windows.Forms.Label lblAktifPassif;
        private System.Windows.Forms.Label lblUrunKategorisi;
    }
}