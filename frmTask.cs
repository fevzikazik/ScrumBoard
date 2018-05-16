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
    public partial class frmTask : Form
    {
        public frmMain anaForm;
        public frmTask()
        {
            InitializeComponent();
        }

        private void rdbTaskEkle_CheckedChanged(object sender, EventArgs e)
        {
            //Genel Kontrollerin Ayarları
            btnTaskDuzenle.Visible = false;
            btnTaskOlustur.Visible = true;
            txtTaskIcerik.Text = txtTaskSahibi.Text = "";
            cmbTaskKategori.Text = "Seçin";
            pbtaskRenkSec.Image = Image.FromFile(Application.StartupPath + "\\renksec.png");
            pbtaskRenkSec.SizeMode = PictureBoxSizeMode.StretchImage;
            pbtaskRenkSec.BackColor = Color.Transparent;

            //paneldeki tüm taskların sayısının 1 fazlası yeni oluşturulucak taskın ID si olur
            lblTaskID.Text = (anaForm.pnlNotStarted.Controls.Count + anaForm.pnlProgress.Controls.Count + anaForm.pnlDone.Controls.Count + 1).ToString();

            cmbTaskListe.Enabled = false;
            if (cmbStListe.Text!="Seçin")
            {
                gbTaskBilgileri.Enabled = true;
            }
            
        }

        private void rdbTaskDuzenle_CheckedChanged(object sender, EventArgs e)
        {
            //Genel Kontrollerin Ayarları
            btnTaskDuzenle.Visible = true;
            btnTaskOlustur.Visible = false;
            gbTaskBilgileri.Enabled = false;
            lblTaskID.Text = "--";
            cmbTaskKategori.Text= "Seçin";
            cmbTaskListe.Enabled = true;
            pbtaskRenkSec.BackColor = Color.Transparent;
            pbtaskRenkSec.Image = Image.FromFile(Application.StartupPath + "\\renksec.png");

            cmbTaskListe.Items.Clear();
            if(cmbStListe.Text!="Seçin")
            {
                foreach (Task temp in anaForm.taskListesi)
                {
                    if (temp.taskStID.ToString() == cmbStListe.Text)
                    {
                        cmbTaskListe.Items.Add(temp.taskID);
                    }
                }
            }
            cmbTaskListe.Text = "Seçin";

        }

        private void cmbTaskListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbTaskBilgileri.Enabled = true;
            pbtaskRenkSec.Image = null;

            foreach (Task temp in anaForm.taskListesi)
            {
                if (temp.taskID.ToString() == cmbTaskListe.Text)
                {
                    lblTaskID.Text = temp.taskID.ToString();
                    txtTaskSahibi.Text = temp.taskSahibi;
                    txtTaskIcerik.Text = temp.taskIcerik;
                    pbtaskRenkSec.BackColor = temp.taskRenk;
                    cmbTaskKategori.Text = temp.taskKategori;
                    dtpTaskYapimTarihi.Value = temp.taskYapimTarihi;
                }
            }
        }

        private void cmbStListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbTaskDuzenle.Enabled = true;
            if (rdbTaskEkle.Checked)
            {
                gbTaskBilgileri.Enabled = true;
            }
            else if (rdbTaskDuzenle.Checked)
            {
                cmbTaskListe.Items.Clear();
                foreach (Task temp in anaForm.taskListesi)
                {
                    if (temp.taskStID.ToString() == cmbStListe.Text)
                    {
                        cmbTaskListe.Items.Add(temp.taskID);
                    }
                }
                cmbTaskListe.Text = "Seçin";
            }            
        }

        private void frmTask_Load(object sender, EventArgs e)
        {
            // Storyleri combobox'a bas
            cmbStListe.Items.Clear();
            foreach (Story temp in anaForm.storyListesi)
            {
                cmbStListe.Items.Add(temp.storyID);
            }

            //Genel Kontrollerin Ayarları
            pbtaskRenkSec.Image = Image.FromFile(Application.StartupPath + "\\renksec.png");
            pbtaskRenkSec.SizeMode = PictureBoxSizeMode.StretchImage;
            pbtaskRenkSec.BackColor = Color.Transparent;
            gbTaskBilgileri.Enabled = false;
            txtTaskSahibi.Text = txtTaskIcerik.Text = "";
            lblTaskID.Text = "--";
            cmbTaskKategori.Text = cmbTaskListe.Text = cmbStListe.Text = "Seçin";
            rdbTaskDuzenle.Enabled = false;
            cmbTaskListe.Enabled = false;
            lblTaskID.Text = (anaForm.pnlNotStarted.Controls.Count + anaForm.pnlProgress.Controls.Count + anaForm.pnlDone.Controls.Count + 1).ToString();
        }

        private void btnTaskDuzenle_Click(object sender, EventArgs e)
        {
            if (txtTaskSahibi.Text != "" && cmbStListe.Text != "Seçin" && cmbTaskListe.Text!="Seçin" && txtTaskSahibi.Text != "" && txtTaskIcerik.Text != "" && cmbTaskKategori.Text != "Seçin" && pbtaskRenkSec.BackColor != Color.Transparent)
            {
                bool isValidColor = true;
                foreach (Task item in anaForm.taskListesi)
                {
                    if (item.taskRenk == pbtaskRenkSec.BackColor)   // renk kontrolü
                    {
                        isValidColor = false;
                    }
                }

                if (isValidColor) // Renk Uygunsa Yani daha önceden oluşturulmamışsa...
                {
                    cmbTaskListe.Items.Clear();
                    foreach (Task temp in anaForm.taskListesi)
                    {
                        if (temp.taskID.ToString() == lblTaskID.Text)
                        {
                            temp.taskSahibi = txtTaskSahibi.Text;
                            temp.taskIcerik = txtTaskIcerik.Text;
                            temp.taskRenk = pbtaskRenkSec.BackColor;
                            temp.taskKategori = cmbTaskKategori.Text;
                            temp.taskYapimTarihi = dtpTaskYapimTarihi.Value;
                        }
                        cmbTaskListe.Items.Add(temp.taskID);
                    }
                    txtTaskSahibi.Text = txtTaskIcerik.Text = "";
                    cmbTaskKategori.Text = cmbTaskListe.Text = "Seçin";
                    pbtaskRenkSec.BackColor = Color.Transparent;
                    pbtaskRenkSec.Image = Image.FromFile(Application.StartupPath + "\\renksec.png");
                    gbTaskBilgileri.Enabled = false;
                    MessageBox.Show("Başarıyla Düzenlendi!");

                    taskYenile();
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz rengi başka bir Task Kullanıyor. Lütfen Değiştirin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Girilen Bilgileri Kontrol Ediniz!");
            }

        }

        public void taskYenile()
        {
            //Panelleri Temizle
            int pnlNotStartedControlSayisi = anaForm.pnlNotStarted.Controls.Count;
            int pnlProgressControlSayisi = anaForm.pnlProgress.Controls.Count;
            int pnlDoneControlSayisi = anaForm.pnlDone.Controls.Count;

            for (int i = 0; i < pnlNotStartedControlSayisi; i++)
            {
                anaForm.pnlNotStarted.Controls.Remove(anaForm.pnlNotStarted.Controls[0]);
            }
            for (int i = 0; i < pnlProgressControlSayisi; i++)
            {
                anaForm.pnlProgress.Controls.Remove(anaForm.pnlProgress.Controls[0]);
            }
            for (int i = 0; i < pnlDoneControlSayisi; i++)
            {
                anaForm.pnlDone.Controls.Remove(anaForm.pnlDone.Controls[0]);
            }

            // picturboxi panellere ekler
            int sonKonumNotStartedY = 10;
            int sonKonumNotStartedX = 20;
            int sayacNotStarted = 0;

            int sonKonumInProgressY = 10;
            int sonKonumInProgressX = 20;
            int sayacInProgres = 0;

            int sonKonumDoneY = 10;
            int sonKonumDoneX = 20;
            int sayacDone = 0;
            
            foreach (Task temp in anaForm.taskListesi)
            {
                PictureBox pb = new PictureBox();
                pb.Height = 30;
                pb.Width = 30;
                pb.Image = Image.FromFile(Application.StartupPath + "\\task.png");
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.BackColor = temp.taskRenk;
                pb.MouseClick += new MouseEventHandler(anaForm.taskBilgiGoster);
                pb.MouseMove += new MouseEventHandler(anaForm.taskTasi_MouseMove);
                pb.MouseUp += new MouseEventHandler(anaForm.taskTasi_MouseUp);
                pb.MouseDown += new MouseEventHandler(anaForm.taskTasi_MouseDown);
                ToolTip Aciklama = new ToolTip();
                Aciklama.ToolTipTitle = "Bilgi!";
                Aciklama.ToolTipIcon = ToolTipIcon.Info;
                Aciklama.IsBalloon = true;
                Aciklama.SetToolTip(pb, "İçeriğini Görüntülemek İçin Sağ Tıklayın. Taşımak İçin Sürükleyin.");

                if (temp.taskKategori == "Not Started")
                {
                    if (sayacNotStarted==3)
                    {
                        sonKonumNotStartedY += 40;
                        sonKonumNotStartedX = 20;
                        sayacNotStarted = 0;
                    }

                    pb.Location = new Point(sonKonumNotStartedX, sonKonumNotStartedY);
                    anaForm.pnlNotStarted.VerticalScroll.Value = 0;
                    anaForm.pnlNotStarted.Controls.Add(pb);
                    sayacNotStarted++;
                    sonKonumNotStartedX += 40;
                }
                else if (temp.taskKategori == "In Progress")
                {
                    if (sayacInProgres == 3)
                    {
                        sonKonumInProgressY += 40;
                        sonKonumInProgressX = 20;
                        sayacInProgres = 0;
                    }

                    pb.Location = new Point(sonKonumInProgressX, sonKonumInProgressY);
                    anaForm.pnlProgress.VerticalScroll.Value = 0;
                    anaForm.pnlProgress.Controls.Add(pb);
                    sayacInProgres++;
                    sonKonumInProgressX += 40;
                }
                else if (temp.taskKategori == "Done")
                {
                    if (sayacDone == 3)
                    {
                        sonKonumDoneY += 40;
                        sonKonumDoneX = 20;
                        sayacNotStarted = 0;
                    }
                    pb.Location = new Point(sonKonumDoneX, sonKonumDoneY);
                    anaForm.pnlDone.VerticalScroll.Value = 0;
                    anaForm.pnlDone.Controls.Add(pb);
                    sayacDone++;
                    sonKonumDoneX += 40;
                }
            }

        }
        
        private void btnTaskOlustur_Click(object sender, EventArgs e)
        {
            if (txtTaskSahibi.Text!="" && cmbStListe.Text!="Seçin" && txtTaskSahibi.Text != "" && txtTaskIcerik.Text!="" && cmbTaskKategori.Text!= "Seçin" && pbtaskRenkSec.BackColor != Color.Transparent)
            {
                bool isValidColor = true;
                foreach (Task item in anaForm.taskListesi)
                {
                    if (item.taskRenk == pbtaskRenkSec.BackColor)   // renk kontrolü
                    {
                        isValidColor = false;
                    }
                }

                if (isValidColor) // Renk Uygunsa Yani daha önceden oluşturulmamışsa...
                {
                    // Story Listesine Ekle
                    Task task = new Task();
                    task.taskID = Convert.ToInt32(lblTaskID.Text);
                    task.taskStID = Convert.ToInt32(cmbStListe.Text);
                    task.taskSahibi = txtTaskSahibi.Text;
                    task.taskIcerik = txtTaskIcerik.Text;
                    task.taskKategori = cmbTaskKategori.Text;
                    task.taskYapimTarihi = dtpTaskYapimTarihi.Value;
                    task.taskRenk = pbtaskRenkSec.BackColor;

                    anaForm.taskListesi.Add(task);

                    taskYenile();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz rengi başka bir Task Kullanıyor. Lütfen Değiştirin!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Girilen Bilgileri Kontrol Ediniz!");
            }
        }

        private void pbtaskRenkSec_Click(object sender, EventArgs e)
        {
            if(taskColorDialog.ShowDialog()==DialogResult.OK)
            {
                if (taskColorDialog.Color!=null)
                {
                    pbtaskRenkSec.BackColor = taskColorDialog.Color;
                    pbtaskRenkSec.Image = null;
                }
                else
                {
                    pbtaskRenkSec.Image = Image.FromFile(Application.StartupPath + "\\renksec.png");
                    pbtaskRenkSec.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbtaskRenkSec.BackColor = Color.Transparent;
                }
            }
        }
    }
}
