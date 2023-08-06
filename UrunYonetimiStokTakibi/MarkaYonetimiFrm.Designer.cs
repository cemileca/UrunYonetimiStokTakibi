namespace UrunYonetimiStokTakibi
{
    partial class MarkaYonetimiFrm
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
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            this.btnMarkaSil = new System.Windows.Forms.Button();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.chkBxDurum = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarkaAdi = new System.Windows.Forms.Label();
            this.lblMarkaAciklama = new System.Windows.Forms.Label();
            this.txtMarkaAdi = new System.Windows.Forms.TextBox();
            this.txtMarkaAciklama = new System.Windows.Forms.TextBox();
            this.dgvMarkalar = new System.Windows.Forms.DataGridView();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mArkaYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriYönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBxMarka = new System.Windows.Forms.GroupBox();
            this.mnStripMarkalar = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkalar)).BeginInit();
            this.grpBxMarka.SuspendLayout();
            this.mnStripMarkalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(197, 348);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(128, 84);
            this.btnMarkaGuncelle.TabIndex = 5;
            this.btnMarkaGuncelle.Text = "Güncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnMarkaSil
            // 
            this.btnMarkaSil.Location = new System.Drawing.Point(370, 348);
            this.btnMarkaSil.Name = "btnMarkaSil";
            this.btnMarkaSil.Size = new System.Drawing.Size(141, 84);
            this.btnMarkaSil.TabIndex = 6;
            this.btnMarkaSil.Text = "Sil";
            this.btnMarkaSil.UseVisualStyleBackColor = true;
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.Location = new System.Drawing.Point(22, 348);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(130, 84);
            this.btnMarkaEkle.TabIndex = 4;
            this.btnMarkaEkle.Text = "Ekle";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            // 
            // chkBxDurum
            // 
            this.chkBxDurum.AutoSize = true;
            this.chkBxDurum.Location = new System.Drawing.Point(229, 241);
            this.chkBxDurum.Name = "chkBxDurum";
            this.chkBxDurum.Size = new System.Drawing.Size(107, 29);
            this.chkBxDurum.TabIndex = 3;
            this.chkBxDurum.Text = "Durum";
            this.chkBxDurum.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eklenme Tarihi";
            // 
            // lblMarkaAdi
            // 
            this.lblMarkaAdi.AutoSize = true;
            this.lblMarkaAdi.Location = new System.Drawing.Point(28, 69);
            this.lblMarkaAdi.Name = "lblMarkaAdi";
            this.lblMarkaAdi.Size = new System.Drawing.Size(109, 25);
            this.lblMarkaAdi.TabIndex = 5;
            this.lblMarkaAdi.Text = "Marka Adı";
            // 
            // lblMarkaAciklama
            // 
            this.lblMarkaAciklama.AutoSize = true;
            this.lblMarkaAciklama.Location = new System.Drawing.Point(28, 139);
            this.lblMarkaAciklama.Name = "lblMarkaAciklama";
            this.lblMarkaAciklama.Size = new System.Drawing.Size(181, 25);
            this.lblMarkaAciklama.TabIndex = 4;
            this.lblMarkaAciklama.Text = "Marka Açıklaması";
            // 
            // txtMarkaAdi
            // 
            this.txtMarkaAdi.Location = new System.Drawing.Point(229, 61);
            this.txtMarkaAdi.Name = "txtMarkaAdi";
            this.txtMarkaAdi.Size = new System.Drawing.Size(282, 31);
            this.txtMarkaAdi.TabIndex = 0;
            // 
            // txtMarkaAciklama
            // 
            this.txtMarkaAciklama.Location = new System.Drawing.Point(229, 125);
            this.txtMarkaAciklama.Multiline = true;
            this.txtMarkaAciklama.Name = "txtMarkaAciklama";
            this.txtMarkaAciklama.Size = new System.Drawing.Size(282, 98);
            this.txtMarkaAciklama.TabIndex = 1;
            // 
            // dgvMarkalar
            // 
            this.dgvMarkalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkalar.Location = new System.Drawing.Point(0, 78);
            this.dgvMarkalar.Name = "dgvMarkalar";
            this.dgvMarkalar.RowHeadersWidth = 82;
            this.dgvMarkalar.RowTemplate.Height = 33;
            this.dgvMarkalar.Size = new System.Drawing.Size(636, 584);
            this.dgvMarkalar.TabIndex = 4;
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            this.kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            this.kullanıcıYönetimiToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            // 
            // ürünYönetimToolStripMenuItem
            // 
            this.ürünYönetimToolStripMenuItem.Name = "ürünYönetimToolStripMenuItem";
            this.ürünYönetimToolStripMenuItem.Size = new System.Drawing.Size(186, 36);
            this.ürünYönetimToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // mArkaYönetimToolStripMenuItem
            // 
            this.mArkaYönetimToolStripMenuItem.Name = "mArkaYönetimToolStripMenuItem";
            this.mArkaYönetimToolStripMenuItem.Size = new System.Drawing.Size(200, 36);
            this.mArkaYönetimToolStripMenuItem.Text = "Marka Yönetimi";
            // 
            // kategoriYönetimToolStripMenuItem
            // 
            this.kategoriYönetimToolStripMenuItem.Name = "kategoriYönetimToolStripMenuItem";
            this.kategoriYönetimToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.kategoriYönetimToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // grpBxMarka
            // 
            this.grpBxMarka.Controls.Add(this.btnMarkaGuncelle);
            this.grpBxMarka.Controls.Add(this.btnMarkaSil);
            this.grpBxMarka.Controls.Add(this.btnMarkaEkle);
            this.grpBxMarka.Controls.Add(this.chkBxDurum);
            this.grpBxMarka.Controls.Add(this.label3);
            this.grpBxMarka.Controls.Add(this.lblMarkaAdi);
            this.grpBxMarka.Controls.Add(this.lblMarkaAciklama);
            this.grpBxMarka.Controls.Add(this.txtMarkaAdi);
            this.grpBxMarka.Controls.Add(this.txtMarkaAciklama);
            this.grpBxMarka.Location = new System.Drawing.Point(649, 121);
            this.grpBxMarka.Name = "grpBxMarka";
            this.grpBxMarka.Size = new System.Drawing.Size(542, 499);
            this.grpBxMarka.TabIndex = 5;
            this.grpBxMarka.TabStop = false;
            this.grpBxMarka.Text = "Marka Yönetimi";
            // 
            // mnStripMarkalar
            // 
            this.mnStripMarkalar.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnStripMarkalar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnStripMarkalar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimToolStripMenuItem,
            this.mArkaYönetimToolStripMenuItem,
            this.ürünYönetimToolStripMenuItem,
            this.kullanıcıYönetimiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.mnStripMarkalar.Location = new System.Drawing.Point(0, 0);
            this.mnStripMarkalar.Name = "mnStripMarkalar";
            this.mnStripMarkalar.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.mnStripMarkalar.Size = new System.Drawing.Size(1228, 44);
            this.mnStripMarkalar.TabIndex = 3;
            this.mnStripMarkalar.Text = "menuStrip1";
            // 
            // MarkaYonetimiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 721);
            this.Controls.Add(this.dgvMarkalar);
            this.Controls.Add(this.grpBxMarka);
            this.Controls.Add(this.mnStripMarkalar);
            this.Name = "MarkaYonetimiFrm";
            this.Text = "MarkaYonetimiFrm";
            this.Load += new System.EventHandler(this.MarkaYonetimiFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkalar)).EndInit();
            this.grpBxMarka.ResumeLayout(false);
            this.grpBxMarka.PerformLayout();
            this.mnStripMarkalar.ResumeLayout(false);
            this.mnStripMarkalar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarkaGuncelle;
        private System.Windows.Forms.Button btnMarkaSil;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.CheckBox chkBxDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMarkaAdi;
        private System.Windows.Forms.Label lblMarkaAciklama;
        private System.Windows.Forms.TextBox txtMarkaAdi;
        private System.Windows.Forms.TextBox txtMarkaAciklama;
        private System.Windows.Forms.DataGridView dgvMarkalar;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mArkaYönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBxMarka;
        private System.Windows.Forms.MenuStrip mnStripMarkalar;
    }
}