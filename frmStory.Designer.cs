namespace YazılımYapımıDonemProjesi
{
    partial class frmStory
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
            this.cmbStDerece = new System.Windows.Forms.ComboBox();
            this.btnStoryOlustur = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTahminiSure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStoryIcerik = new System.Windows.Forms.TextBox();
            this.txtStBaslik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStoryID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbStoryBilgileri = new System.Windows.Forms.GroupBox();
            this.btnStoryDuzenle = new System.Windows.Forms.Button();
            this.gbSecim = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStListe = new System.Windows.Forms.ComboBox();
            this.rdbStDuzenle = new System.Windows.Forms.RadioButton();
            this.rdbStEkle = new System.Windows.Forms.RadioButton();
            this.gbStoryBilgileri.SuspendLayout();
            this.gbSecim.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStDerece
            // 
            this.cmbStDerece.FormattingEnabled = true;
            this.cmbStDerece.Items.AddRange(new object[] {
            "Çok Önemli",
            "Önemli",
            "Orta",
            "Az"});
            this.cmbStDerece.Location = new System.Drawing.Point(332, 37);
            this.cmbStDerece.Name = "cmbStDerece";
            this.cmbStDerece.Size = new System.Drawing.Size(81, 21);
            this.cmbStDerece.TabIndex = 33;
            this.cmbStDerece.Text = "Seçin";
            // 
            // btnStoryOlustur
            // 
            this.btnStoryOlustur.Location = new System.Drawing.Point(327, 126);
            this.btnStoryOlustur.Name = "btnStoryOlustur";
            this.btnStoryOlustur.Size = new System.Drawing.Size(90, 29);
            this.btnStoryOlustur.TabIndex = 32;
            this.btnStoryOlustur.Text = "Story Oluştur";
            this.btnStoryOlustur.UseVisualStyleBackColor = true;
            this.btnStoryOlustur.Click += new System.EventHandler(this.btnStoryOlustur_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tahmini Süre(Gün):";
            // 
            // txtTahminiSure
            // 
            this.txtTahminiSure.Location = new System.Drawing.Point(332, 90);
            this.txtTahminiSure.Name = "txtTahminiSure";
            this.txtTahminiSure.Size = new System.Drawing.Size(81, 20);
            this.txtTahminiSure.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Önem Derecesi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Story İçeriği:";
            // 
            // txtStoryIcerik
            // 
            this.txtStoryIcerik.Location = new System.Drawing.Point(31, 68);
            this.txtStoryIcerik.Multiline = true;
            this.txtStoryIcerik.Name = "txtStoryIcerik";
            this.txtStoryIcerik.Size = new System.Drawing.Size(273, 93);
            this.txtStoryIcerik.TabIndex = 23;
            // 
            // txtStBaslik
            // 
            this.txtStBaslik.Location = new System.Drawing.Point(195, 21);
            this.txtStBaslik.Name = "txtStBaslik";
            this.txtStBaslik.Size = new System.Drawing.Size(89, 20);
            this.txtStBaslik.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Story Başlığı:";
            // 
            // lblStoryID
            // 
            this.lblStoryID.AutoSize = true;
            this.lblStoryID.Location = new System.Drawing.Point(92, 24);
            this.lblStoryID.Name = "lblStoryID";
            this.lblStoryID.Size = new System.Drawing.Size(13, 13);
            this.lblStoryID.TabIndex = 35;
            this.lblStoryID.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Story ID:";
            // 
            // gbStoryBilgileri
            // 
            this.gbStoryBilgileri.Controls.Add(this.txtStoryIcerik);
            this.gbStoryBilgileri.Controls.Add(this.txtStBaslik);
            this.gbStoryBilgileri.Controls.Add(this.label5);
            this.gbStoryBilgileri.Controls.Add(this.label4);
            this.gbStoryBilgileri.Controls.Add(this.label6);
            this.gbStoryBilgileri.Controls.Add(this.lblStoryID);
            this.gbStoryBilgileri.Controls.Add(this.txtTahminiSure);
            this.gbStoryBilgileri.Controls.Add(this.label2);
            this.gbStoryBilgileri.Controls.Add(this.label7);
            this.gbStoryBilgileri.Controls.Add(this.cmbStDerece);
            this.gbStoryBilgileri.Controls.Add(this.btnStoryOlustur);
            this.gbStoryBilgileri.Controls.Add(this.btnStoryDuzenle);
            this.gbStoryBilgileri.Location = new System.Drawing.Point(233, 30);
            this.gbStoryBilgileri.Name = "gbStoryBilgileri";
            this.gbStoryBilgileri.Size = new System.Drawing.Size(451, 182);
            this.gbStoryBilgileri.TabIndex = 38;
            this.gbStoryBilgileri.TabStop = false;
            this.gbStoryBilgileri.Text = "Story Bilgileri";
            // 
            // btnStoryDuzenle
            // 
            this.btnStoryDuzenle.Location = new System.Drawing.Point(327, 126);
            this.btnStoryDuzenle.Name = "btnStoryDuzenle";
            this.btnStoryDuzenle.Size = new System.Drawing.Size(90, 29);
            this.btnStoryDuzenle.TabIndex = 40;
            this.btnStoryDuzenle.Text = "Story Düzenle";
            this.btnStoryDuzenle.UseVisualStyleBackColor = true;
            this.btnStoryDuzenle.Click += new System.EventHandler(this.btnStoryDuzenle_Click);
            // 
            // gbSecim
            // 
            this.gbSecim.Controls.Add(this.label1);
            this.gbSecim.Controls.Add(this.label3);
            this.gbSecim.Controls.Add(this.cmbStListe);
            this.gbSecim.Controls.Add(this.rdbStDuzenle);
            this.gbSecim.Controls.Add(this.rdbStEkle);
            this.gbSecim.Location = new System.Drawing.Point(28, 30);
            this.gbSecim.Name = "gbSecim";
            this.gbSecim.Size = new System.Drawing.Size(198, 182);
            this.gbSecim.TabIndex = 39;
            this.gbSecim.TabStop = false;
            this.gbSecim.Text = "Story Yönet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Lütfen İşlem Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Story Başlığı:";
            // 
            // cmbStListe
            // 
            this.cmbStListe.FormattingEnabled = true;
            this.cmbStListe.Location = new System.Drawing.Point(82, 119);
            this.cmbStListe.Name = "cmbStListe";
            this.cmbStListe.Size = new System.Drawing.Size(81, 21);
            this.cmbStListe.TabIndex = 36;
            this.cmbStListe.Text = "Seçin";
            this.cmbStListe.SelectedIndexChanged += new System.EventHandler(this.cmbStListe_SelectedIndexChanged);
            // 
            // rdbStDuzenle
            // 
            this.rdbStDuzenle.AutoSize = true;
            this.rdbStDuzenle.Location = new System.Drawing.Point(12, 93);
            this.rdbStDuzenle.Name = "rdbStDuzenle";
            this.rdbStDuzenle.Size = new System.Drawing.Size(64, 17);
            this.rdbStDuzenle.TabIndex = 1;
            this.rdbStDuzenle.TabStop = true;
            this.rdbStDuzenle.Text = "Düzenle";
            this.rdbStDuzenle.UseVisualStyleBackColor = true;
            this.rdbStDuzenle.CheckedChanged += new System.EventHandler(this.rdbStDuzenle_CheckedChanged);
            // 
            // rdbStEkle
            // 
            this.rdbStEkle.AutoSize = true;
            this.rdbStEkle.Location = new System.Drawing.Point(12, 68);
            this.rdbStEkle.Name = "rdbStEkle";
            this.rdbStEkle.Size = new System.Drawing.Size(70, 17);
            this.rdbStEkle.TabIndex = 0;
            this.rdbStEkle.TabStop = true;
            this.rdbStEkle.Text = "Yeni Ekle";
            this.rdbStEkle.UseVisualStyleBackColor = true;
            this.rdbStEkle.CheckedChanged += new System.EventHandler(this.rdbStEkle_CheckedChanged);
            // 
            // frmStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 242);
            this.Controls.Add(this.gbSecim);
            this.Controls.Add(this.gbStoryBilgileri);
            this.Name = "frmStory";
            this.Text = "frmStory";
            this.Load += new System.EventHandler(this.frmStory_Load);
            this.gbStoryBilgileri.ResumeLayout(false);
            this.gbStoryBilgileri.PerformLayout();
            this.gbSecim.ResumeLayout(false);
            this.gbSecim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStDerece;
        public System.Windows.Forms.Button btnStoryOlustur;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTahminiSure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtStoryIcerik;
        public System.Windows.Forms.TextBox txtStBaslik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStoryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSecim;
        private System.Windows.Forms.RadioButton rdbStDuzenle;
        private System.Windows.Forms.RadioButton rdbStEkle;
        private System.Windows.Forms.GroupBox gbStoryBilgileri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStListe;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnStoryDuzenle;
    }
}