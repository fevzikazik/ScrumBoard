using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımıDonemProjesi
{
    public partial class frmStory : Form
    {
        public frmMain anaForm;
        public frmStory()
        {
            InitializeComponent();
        }

        private void frmStory_Load(object sender, EventArgs e)
        {
            // Genel Ayarlar
            txtTahminiSure.Text = txtStoryIcerik.Text = txtStBaslik.Text = "";
            int yeniID = anaForm.pnlStroies.Controls.Count + 1;
            lblStoryID.Text = yeniID.ToString();
            cmbStListe.Enabled = false;
            cmbStListe.Items.Clear();                 
            txtTahminiSure.Text = txtStoryIcerik.Text = txtStBaslik.Text = "";
            cmbStDerece.Text = "Seçin";
            cmbStListe.Text = "Seçin";
            rdbStEkle.Checked = true;
            gbStoryBilgileri.Enabled = true;
            

            foreach (Story temp in anaForm.storyListesi)
            {
                cmbStListe.Items.Add(temp.stBaslik);  // Listeden Storyleri cmbListe ye Basar.
            }
        }

        private void btnStoryOlustur_Click(object sender, EventArgs e)
        {
            if (txtStBaslik.Text != "" && txtStBaslik.Text != "" && txtStoryIcerik.Text != "" && cmbStDerece.Text != "Seçin" && txtTahminiSure.Text != "" && lblStoryID.Text != "--")
            {
                // Story Listesine Ekle
                Story st = new Story();
                st.storyID = Convert.ToInt32(lblStoryID.Text);
                st.stBaslik = txtStBaslik.Text;
                st.stIcerik = txtStoryIcerik.Text;
                st.stOnemDerecesi = cmbStDerece.Text;
                st.stTahminiSure = Convert.ToInt32(txtTahminiSure.Text);


                // önceden oluşmamış renk oluşturma
                Random rnd = new Random();
                int renk1 = rnd.Next(80, 255);
                int renk2 = rnd.Next(80, 255);
                int renk3 = rnd.Next(80, 255);
                Color yenirenk = Color.FromArgb(renk1, renk2, renk3);

                foreach (Story temp in anaForm.storyListesi)
                {
                    while (temp.stRenk == yenirenk)
                    {
                        renk1 = rnd.Next(50, 255);
                        renk2 = rnd.Next(50, 255);
                        renk3 = rnd.Next(50, 255);
                        yenirenk = Color.FromArgb(renk1, renk2, renk3);
                    }
                }

                st.stRenk = yenirenk;
                anaForm.storyListesi.Add(st);

                storyYenile();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Girilen Bilgileri Kontrol Ediniz!");
            }
        }

        void storyYenile()
        {
            //Paneli Temizle
            int pnlStoriesControlSayisi = anaForm.pnlStroies.Controls.Count;
            for (int i = 0; i < pnlStoriesControlSayisi; i++)
            {
                anaForm.pnlStroies.Controls.Remove(anaForm.pnlStroies.Controls[0]);
            }

            int sonKonum = 25;
            foreach (Story temp in anaForm.storyListesi)
            {
                // PictureBox ile ikon ekle
                PictureBox pb = new PictureBox();
                pb.Location = new Point(20, sonKonum);
                sonKonum += 70;
                pb.Height = 60;
                pb.Width = 100;
                pb.Image = Image.FromFile(Application.StartupPath + "\\userstories.png");
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.BackColor = temp.stRenk;
                pb.MouseClick += new MouseEventHandler(anaForm.storyBilgiGoster);
                pb.MouseMove += new MouseEventHandler(anaForm.storyTasi_MouseMove);
                pb.MouseUp += new MouseEventHandler(anaForm.storyTasi_MouseUp);
                pb.MouseDown += new MouseEventHandler(anaForm.storyTasi_MouseDown);

                ToolTip Aciklama = new ToolTip();
                Aciklama.ToolTipTitle = "Bilgi!";
                Aciklama.ToolTipIcon = ToolTipIcon.Info;
                Aciklama.IsBalloon = true;
                Aciklama.SetToolTip(pb, "İçeriğini Görüntülemek İçin Sağ Tıklayın. Taşımak İçin Sürükleyin.");

                anaForm.pnlStroies.VerticalScroll.Value = 0; // ince ayar
                anaForm.pnlStroies.Controls.Add(pb); // picturboxi panele ekler
            }
        }

        private void rdbStEkle_CheckedChanged(object sender, EventArgs e)
        {
            //Genel Ayarlar
            btnStoryDuzenle.Visible = false;
            btnStoryOlustur.Visible = true;
            cmbStListe.Enabled = false;
            gbStoryBilgileri.Enabled = true;
            txtTahminiSure.Text = txtStoryIcerik.Text = txtStBaslik.Text = "";
            int yeniStID = anaForm.pnlStroies.Controls.Count + 1;
            lblStoryID.Text = yeniStID.ToString();
            cmbStDerece.Text = "Seçin";

        }

        private void rdbStDuzenle_CheckedChanged(object sender, EventArgs e)
        {
            //Genel Ayarlar
            btnStoryDuzenle.Visible = true;
            btnStoryOlustur.Visible = false;
            cmbStListe.Enabled = true;
            gbStoryBilgileri.Enabled = false;
            lblStoryID.Text = "--";
            cmbStListe.Text = "Seçin";
            txtTahminiSure.Text = txtStoryIcerik.Text = txtStBaslik.Text = "";
            cmbStDerece.Text = "Seçin";
        }

        private void cmbStListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbStoryBilgileri.Enabled = true;


            foreach (Story temp in anaForm.storyListesi)
            {
                if (temp.stBaslik == cmbStListe.Text)
                {
                    txtStBaslik.Text = temp.stBaslik;
                    txtStoryIcerik.Text = temp.stIcerik;
                    txtTahminiSure.Text = temp.stTahminiSure.ToString();
                    lblStoryID.Text = temp.storyID.ToString();
                    cmbStDerece.Text = temp.stOnemDerecesi;
                }
            }
        }

        private void btnStoryDuzenle_Click(object sender, EventArgs e)
        {
            if (txtStBaslik.Text != "" && cmbStListe.Text != "Seçin" && txtStBaslik.Text != "" && txtStoryIcerik.Text != "" && cmbStDerece.Text != "Seçin" && txtTahminiSure.Text != "" && lblStoryID.Text != "--")
            {
                cmbStListe.Items.Clear();
                foreach (Story temp in anaForm.storyListesi)
                {
                    if (temp.storyID.ToString() == lblStoryID.Text)
                    {
                        temp.stBaslik = txtStBaslik.Text;
                        temp.stIcerik = txtStoryIcerik.Text;
                        temp.stTahminiSure = Convert.ToInt32(txtTahminiSure.Text);
                        temp.stOnemDerecesi = cmbStDerece.Text;
                    }
                    cmbStListe.Items.Add(temp.stBaslik);
                }
                txtStBaslik.Text = txtStoryIcerik.Text = txtTahminiSure.Text = lblStoryID.Text =  "";
                cmbStDerece.Text = cmbStListe.Text = "Seçin";
                gbStoryBilgileri.Enabled = false;
                MessageBox.Show("Başarıyla Düzenlendi!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Girilen Bilgileri Kontrol Ediniz!");
            }
        }
    }
}
