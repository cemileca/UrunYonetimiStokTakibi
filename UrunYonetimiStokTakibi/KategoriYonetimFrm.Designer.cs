namespace UrunYonetimiStokTakibi
{
    partial class KategoriYonetimFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mArkaYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDurum = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdı = new System.Windows.Forms.TextBox();
            this.txtKategoriAciklamasi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimToolStripMenuItem,
            this.mArkaYönetimToolStripMenuItem,
            this.ürünYönetimToolStripMenuItem,
            this.kullanıcıYönetimiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1718, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriYönetimToolStripMenuItem
            // 
            this.kategoriYönetimToolStripMenuItem.Name = "kategoriYönetimToolStripMenuItem";
            this.kategoriYönetimToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.kategoriYönetimToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // mArkaYönetimToolStripMenuItem
            // 
            this.mArkaYönetimToolStripMenuItem.Name = "mArkaYönetimToolStripMenuItem";
            this.mArkaYönetimToolStripMenuItem.Size = new System.Drawing.Size(200, 36);
            this.mArkaYönetimToolStripMenuItem.Text = "Marka Yönetimi";
            // 
            // ürünYönetimToolStripMenuItem
            // 
            this.ürünYönetimToolStripMenuItem.Name = "ürünYönetimToolStripMenuItem";
            this.ürünYönetimToolStripMenuItem.Size = new System.Drawing.Size(186, 36);
            this.ürünYönetimToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            this.kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            this.kullanıcıYönetimiToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(976, 846);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cbxDurum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKategoriAdı);
            this.groupBox1.Controls.Add(this.txtKategoriAciklamasi);
            this.groupBox1.Location = new System.Drawing.Point(1013, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 523);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Yönetimi";
            // 
            // cbxDurum
            // 
            this.cbxDurum.AutoSize = true;
            this.cbxDurum.Location = new System.Drawing.Point(300, 267);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(145, 28);
            this.cbxDurum.TabIndex = 3;
            this.cbxDurum.Text = "checkBox1";
            this.cbxDurum.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eklenme Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategori Açıklaması";
            // 
            // txtKategoriAdı
            // 
            this.txtKategoriAdı.Location = new System.Drawing.Point(300, 63);
            this.txtKategoriAdı.Name = "txtKategoriAdı";
            this.txtKategoriAdı.Size = new System.Drawing.Size(345, 32);
            this.txtKategoriAdı.TabIndex = 0;
            // 
            // txtKategoriAciklamasi
            // 
            this.txtKategoriAciklamasi.Location = new System.Drawing.Point(300, 139);
            this.txtKategoriAciklamasi.Multiline = true;
            this.txtKategoriAciklamasi.Name = "txtKategoriAciklamasi";
            this.txtKategoriAciklamasi.Size = new System.Drawing.Size(345, 98);
            this.txtKategoriAciklamasi.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(34, 380);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(187, 104);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(454, 380);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(174, 104);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(250, 380);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(174, 104);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // KategoriYonetimFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1718, 929);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KategoriYonetimFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Yönetimi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mArkaYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriAdı;
        private System.Windows.Forms.TextBox txtKategoriAciklamasi;
        private System.Windows.Forms.CheckBox cbxDurum;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
    }
}