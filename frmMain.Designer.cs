namespace YazılımYapımıDonemProjesi
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStoryEkle = new System.Windows.Forms.Button();
            this.pnlStroies = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNotStarted = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.labelDone = new System.Windows.Forms.Label();
            this.pnlDone = new System.Windows.Forms.Panel();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.Location = new System.Drawing.Point(241, 456);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(121, 29);
            this.btnStoryEkle.TabIndex = 4;
            this.btnStoryEkle.Text = "Story Yönet";
            this.btnStoryEkle.UseVisualStyleBackColor = true;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // pnlStroies
            // 
            this.pnlStroies.AutoScroll = true;
            this.pnlStroies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStroies.Location = new System.Drawing.Point(22, 49);
            this.pnlStroies.Name = "pnlStroies";
            this.pnlStroies.Size = new System.Drawing.Size(151, 379);
            this.pnlStroies.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Not Started";
            // 
            // pnlNotStarted
            // 
            this.pnlNotStarted.AutoScroll = true;
            this.pnlNotStarted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotStarted.Location = new System.Drawing.Point(190, 49);
            this.pnlNotStarted.Name = "pnlNotStarted";
            this.pnlNotStarted.Size = new System.Drawing.Size(151, 379);
            this.pnlNotStarted.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "In Progress";
            // 
            // pnlProgress
            // 
            this.pnlProgress.AutoScroll = true;
            this.pnlProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProgress.Location = new System.Drawing.Point(358, 49);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(151, 379);
            this.pnlProgress.TabIndex = 9;
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.Location = new System.Drawing.Point(575, 33);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(33, 13);
            this.labelDone.TabIndex = 8;
            this.labelDone.Text = "Done";
            // 
            // pnlDone
            // 
            this.pnlDone.AutoScroll = true;
            this.pnlDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDone.Location = new System.Drawing.Point(527, 49);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(151, 379);
            this.pnlDone.TabIndex = 7;
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Location = new System.Drawing.Point(368, 456);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(121, 29);
            this.btnTaskEkle.TabIndex = 11;
            this.btnTaskEkle.Text = "Task Yönet";
            this.btnTaskEkle.UseVisualStyleBackColor = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 513);
            this.Controls.Add(this.btnTaskEkle);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlDone);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlNotStarted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlStroies);
            this.Controls.Add(this.btnStoryEkle);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrum Board";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStoryEkle;
        public System.Windows.Forms.Panel pnlStroies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnlNotStarted;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label labelDone;
        public System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.Button btnTaskEkle;
    }
}

