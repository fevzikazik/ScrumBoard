namespace YazılımYapımıDonemProjesi
{
    partial class frmTask
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
            this.gbSecim = new System.Windows.Forms.GroupBox();
            this.rdbTaskEkle = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTaskListe = new System.Windows.Forms.ComboBox();
            this.rdbTaskDuzenle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStListe = new System.Windows.Forms.ComboBox();
            this.gbTaskBilgileri = new System.Windows.Forms.GroupBox();
            this.btnTaskOlustur = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pbtaskRenkSec = new System.Windows.Forms.PictureBox();
            this.dtpTaskYapimTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTaskIcerik = new System.Windows.Forms.TextBox();
            this.txtTaskSahibi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTaskKategori = new System.Windows.Forms.ComboBox();
            this.btnTaskDuzenle = new System.Windows.Forms.Button();
            this.taskColorDialog = new System.Windows.Forms.ColorDialog();
            this.gbSecim.SuspendLayout();
            this.gbTaskBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtaskRenkSec)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSecim
            // 
            this.gbSecim.Controls.Add(this.rdbTaskEkle);
            this.gbSecim.Controls.Add(this.label3);
            this.gbSecim.Controls.Add(this.cmbTaskListe);
            this.gbSecim.Controls.Add(this.rdbTaskDuzenle);
            this.gbSecim.Controls.Add(this.label1);
            this.gbSecim.Controls.Add(this.cmbStListe);
            this.gbSecim.Location = new System.Drawing.Point(12, 22);
            this.gbSecim.Name = "gbSecim";
            this.gbSecim.Size = new System.Drawing.Size(239, 177);
            this.gbSecim.TabIndex = 41;
            this.gbSecim.TabStop = false;
            this.gbSecim.Text = "Task Yönet";
            // 
            // rdbTaskEkle
            // 
            this.rdbTaskEkle.AutoSize = true;
            this.rdbTaskEkle.Location = new System.Drawing.Point(22, 81);
            this.rdbTaskEkle.Name = "rdbTaskEkle";
            this.rdbTaskEkle.Size = new System.Drawing.Size(70, 17);
            this.rdbTaskEkle.TabIndex = 0;
            this.rdbTaskEkle.TabStop = true;
            this.rdbTaskEkle.Text = "Yeni Ekle";
            this.rdbTaskEkle.UseVisualStyleBackColor = true;
            this.rdbTaskEkle.CheckedChanged += new System.EventHandler(this.rdbTaskEkle_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Task ID:";
            // 
            // cmbTaskListe
            // 
            this.cmbTaskListe.FormattingEnabled = true;
            this.cmbTaskListe.Location = new System.Drawing.Point(122, 136);
            this.cmbTaskListe.Name = "cmbTaskListe";
            this.cmbTaskListe.Size = new System.Drawing.Size(81, 21);
            this.cmbTaskListe.TabIndex = 42;
            this.cmbTaskListe.Text = "Seçin";
            this.cmbTaskListe.SelectedIndexChanged += new System.EventHandler(this.cmbTaskListe_SelectedIndexChanged);
            // 
            // rdbTaskDuzenle
            // 
            this.rdbTaskDuzenle.AutoSize = true;
            this.rdbTaskDuzenle.Location = new System.Drawing.Point(22, 110);
            this.rdbTaskDuzenle.Name = "rdbTaskDuzenle";
            this.rdbTaskDuzenle.Size = new System.Drawing.Size(64, 17);
            this.rdbTaskDuzenle.TabIndex = 1;
            this.rdbTaskDuzenle.TabStop = true;
            this.rdbTaskDuzenle.Text = "Düzenle";
            this.rdbTaskDuzenle.UseVisualStyleBackColor = true;
            this.rdbTaskDuzenle.CheckedChanged += new System.EventHandler(this.rdbTaskDuzenle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Lütfen StoryID Seçin:";
            // 
            // cmbStListe
            // 
            this.cmbStListe.FormattingEnabled = true;
            this.cmbStListe.Location = new System.Drawing.Point(129, 32);
            this.cmbStListe.Name = "cmbStListe";
            this.cmbStListe.Size = new System.Drawing.Size(81, 21);
            this.cmbStListe.TabIndex = 36;
            this.cmbStListe.Text = "Seçin";
            this.cmbStListe.SelectedIndexChanged += new System.EventHandler(this.cmbStListe_SelectedIndexChanged);
            // 
            // gbTaskBilgileri
            // 
            this.gbTaskBilgileri.Controls.Add(this.btnTaskOlustur);
            this.gbTaskBilgileri.Controls.Add(this.label8);
            this.gbTaskBilgileri.Controls.Add(this.pbtaskRenkSec);
            this.gbTaskBilgileri.Controls.Add(this.dtpTaskYapimTarihi);
            this.gbTaskBilgileri.Controls.Add(this.txtTaskIcerik);
            this.gbTaskBilgileri.Controls.Add(this.txtTaskSahibi);
            this.gbTaskBilgileri.Controls.Add(this.label5);
            this.gbTaskBilgileri.Controls.Add(this.label4);
            this.gbTaskBilgileri.Controls.Add(this.label6);
            this.gbTaskBilgileri.Controls.Add(this.lblTaskID);
            this.gbTaskBilgileri.Controls.Add(this.label2);
            this.gbTaskBilgileri.Controls.Add(this.label7);
            this.gbTaskBilgileri.Controls.Add(this.cmbTaskKategori);
            this.gbTaskBilgileri.Controls.Add(this.btnTaskDuzenle);
            this.gbTaskBilgileri.Enabled = false;
            this.gbTaskBilgileri.Location = new System.Drawing.Point(275, 22);
            this.gbTaskBilgileri.Name = "gbTaskBilgileri";
            this.gbTaskBilgileri.Size = new System.Drawing.Size(454, 217);
            this.gbTaskBilgileri.TabIndex = 40;
            this.gbTaskBilgileri.TabStop = false;
            this.gbTaskBilgileri.Text = "Task Bilgileri";
            // 
            // btnTaskOlustur
            // 
            this.btnTaskOlustur.Location = new System.Drawing.Point(336, 175);
            this.btnTaskOlustur.Name = "btnTaskOlustur";
            this.btnTaskOlustur.Size = new System.Drawing.Size(100, 29);
            this.btnTaskOlustur.TabIndex = 32;
            this.btnTaskOlustur.Text = "Task Oluştur";
            this.btnTaskOlustur.UseVisualStyleBackColor = true;
            this.btnTaskOlustur.Click += new System.EventHandler(this.btnTaskOlustur_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Task Rengini Seç:";
            // 
            // pbtaskRenkSec
            // 
            this.pbtaskRenkSec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbtaskRenkSec.Location = new System.Drawing.Point(336, 58);
            this.pbtaskRenkSec.Name = "pbtaskRenkSec";
            this.pbtaskRenkSec.Size = new System.Drawing.Size(100, 94);
            this.pbtaskRenkSec.TabIndex = 43;
            this.pbtaskRenkSec.TabStop = false;
            this.pbtaskRenkSec.Click += new System.EventHandler(this.pbtaskRenkSec_Click);
            // 
            // dtpTaskYapimTarihi
            // 
            this.dtpTaskYapimTarihi.Location = new System.Drawing.Point(145, 181);
            this.dtpTaskYapimTarihi.Name = "dtpTaskYapimTarihi";
            this.dtpTaskYapimTarihi.Size = new System.Drawing.Size(174, 20);
            this.dtpTaskYapimTarihi.TabIndex = 42;
            // 
            // txtTaskIcerik
            // 
            this.txtTaskIcerik.Location = new System.Drawing.Point(25, 84);
            this.txtTaskIcerik.Multiline = true;
            this.txtTaskIcerik.Name = "txtTaskIcerik";
            this.txtTaskIcerik.Size = new System.Drawing.Size(294, 68);
            this.txtTaskIcerik.TabIndex = 23;
            // 
            // txtTaskSahibi
            // 
            this.txtTaskSahibi.Location = new System.Drawing.Point(189, 33);
            this.txtTaskSahibi.Name = "txtTaskSahibi";
            this.txtTaskSahibi.Size = new System.Drawing.Size(130, 20);
            this.txtTaskSahibi.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Task İçeriği:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Task Sahibi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Task Kategori:";
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Location = new System.Drawing.Point(86, 36);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(13, 13);
            this.lblTaskID.TabIndex = 35;
            this.lblTaskID.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Task ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Yapım Tarihi:";
            // 
            // cmbTaskKategori
            // 
            this.cmbTaskKategori.FormattingEnabled = true;
            this.cmbTaskKategori.Items.AddRange(new object[] {
            "Not Started",
            "In Progress",
            "Done"});
            this.cmbTaskKategori.Location = new System.Drawing.Point(26, 180);
            this.cmbTaskKategori.Name = "cmbTaskKategori";
            this.cmbTaskKategori.Size = new System.Drawing.Size(100, 21);
            this.cmbTaskKategori.TabIndex = 33;
            this.cmbTaskKategori.Text = "Seçin";
            // 
            // btnTaskDuzenle
            // 
            this.btnTaskDuzenle.Location = new System.Drawing.Point(336, 175);
            this.btnTaskDuzenle.Name = "btnTaskDuzenle";
            this.btnTaskDuzenle.Size = new System.Drawing.Size(100, 29);
            this.btnTaskDuzenle.TabIndex = 40;
            this.btnTaskDuzenle.Text = "Task Düzenle";
            this.btnTaskDuzenle.UseVisualStyleBackColor = true;
            this.btnTaskDuzenle.Click += new System.EventHandler(this.btnTaskDuzenle_Click);
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 251);
            this.Controls.Add(this.gbSecim);
            this.Controls.Add(this.gbTaskBilgileri);
            this.Name = "frmTask";
            this.Text = "frmTask";
            this.Load += new System.EventHandler(this.frmTask_Load);
            this.gbSecim.ResumeLayout(false);
            this.gbSecim.PerformLayout();
            this.gbTaskBilgileri.ResumeLayout(false);
            this.gbTaskBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtaskRenkSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSecim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStListe;
        private System.Windows.Forms.RadioButton rdbTaskDuzenle;
        private System.Windows.Forms.RadioButton rdbTaskEkle;
        private System.Windows.Forms.GroupBox gbTaskBilgileri;
        public System.Windows.Forms.Button btnTaskDuzenle;
        public System.Windows.Forms.TextBox txtTaskIcerik;
        public System.Windows.Forms.TextBox txtTaskSahibi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTaskKategori;
        public System.Windows.Forms.Button btnTaskOlustur;
        private System.Windows.Forms.ComboBox cmbTaskListe;
        private System.Windows.Forms.DateTimePicker dtpTaskYapimTarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbtaskRenkSec;
        private System.Windows.Forms.ColorDialog taskColorDialog;
    }
}