namespace KayıtFormu
{
    partial class KayitForm
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
            this.TSMI_Islemler = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_YeniPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PersonelListele = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PersonelBilgileriniGüncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PersonelSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Islemler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Islemler
            // 
            this.TSMI_Islemler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_YeniPersonel,
            this.TSMI_PersonelListele,
            this.TSMI_PersonelBilgileriniGüncelle,
            this.TSMI_PersonelSil,
            this.toolStripSeparator1,
            this.TSMI_Kapat});
            this.TSMI_Islemler.Name = "TSMI_Islemler";
            this.TSMI_Islemler.Size = new System.Drawing.Size(60, 20);
            this.TSMI_Islemler.Text = "İşlemler";
            // 
            // TSMI_YeniPersonel
            // 
            this.TSMI_YeniPersonel.Name = "TSMI_YeniPersonel";
            this.TSMI_YeniPersonel.Size = new System.Drawing.Size(220, 22);
            this.TSMI_YeniPersonel.Text = "Yeni Personel";
            // 
            // TSMI_PersonelListele
            // 
            this.TSMI_PersonelListele.Name = "TSMI_PersonelListele";
            this.TSMI_PersonelListele.Size = new System.Drawing.Size(220, 22);
            this.TSMI_PersonelListele.Text = "Personel Listele";
            // 
            // TSMI_PersonelBilgileriniGüncelle
            // 
            this.TSMI_PersonelBilgileriniGüncelle.Name = "TSMI_PersonelBilgileriniGüncelle";
            this.TSMI_PersonelBilgileriniGüncelle.Size = new System.Drawing.Size(220, 22);
            this.TSMI_PersonelBilgileriniGüncelle.Text = "Personel Bilgilerini Güncelle";
            // 
            // TSMI_PersonelSil
            // 
            this.TSMI_PersonelSil.Name = "TSMI_PersonelSil";
            this.TSMI_PersonelSil.Size = new System.Drawing.Size(220, 22);
            this.TSMI_PersonelSil.Text = "Personel Sil";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // TSMI_Kapat
            // 
            this.TSMI_Kapat.Name = "TSMI_Kapat";
            this.TSMI_Kapat.Size = new System.Drawing.Size(220, 22);
            this.TSMI_Kapat.Text = "Kapat";
            // 
            // KayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KayitForm";
            this.Text = "KayıtForm";
            this.Load += new System.EventHandler(this.KayitForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Islemler;
        private System.Windows.Forms.ToolStripMenuItem TSMI_YeniPersonel;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PersonelListele;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PersonelBilgileriniGüncelle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PersonelSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kapat;
    }
}