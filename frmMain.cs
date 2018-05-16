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
    public partial class frmMain : Form
    {
        public frmStory frmStory;
        public frmTask frmTask;
        public List<Story> storyListesi { get; set; }
        public List<Task> taskListesi { get; set; }

        public frmMain()
        {
            InitializeComponent();
            frmStory = new frmStory();
            frmTask = new frmTask();
            storyListesi = new List<Story>();
            taskListesi = new List<Task>();
            frmStory.anaForm = this;
            frmTask.anaForm = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            frmStory.StartPosition = FormStartPosition.CenterParent;
            frmStory.ShowDialog();
        }

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            frmTask.StartPosition = FormStartPosition.CenterParent;
            frmTask.ShowDialog();
        }

        public void storyBilgiGoster(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Color alinanrenk = (sender as PictureBox).BackColor;
                foreach (Story temp in storyListesi)
                {
                    if (temp.stRenk == alinanrenk)
                    {
                        MessageBox.Show("StoryID : " + temp.storyID + Environment.NewLine + "Story Başlığı : " + temp.stBaslik + Environment.NewLine + "Story Önem Derecesi : " + temp.stOnemDerecesi + Environment.NewLine + "Story Tahmini Süresi : " + temp.stTahminiSure + Environment.NewLine + "Story İçeriği : " + temp.stIcerik, "Story Bilgileri");
                    }
                }
            }
        }

        bool suruklenmedurumu = false; //Class seviyesinde bir field(değişken) tanımlıyoruz ki,MouseDown da biz bunu true yapacağız,MouseUpta false değerini alacak ve MouseMove eventında true ise hareket edecek.     
        Point ilkkonum; //Global bir değişken tanımlıyoruz ki, ilk tıkladığımız andaki konumunu çıkarmadığımızda pbSecilen mouse imlecinden daha aşağıdan hareket edecektir.
        public void storyTasi_MouseDown(object sender, MouseEventArgs e)
        {
                    PictureBox pbSecilen = (sender as PictureBox);
                    suruklenmedurumu = true; //işlemi burada true diyerek başlatıyoruz.
                    pbSecilen.Cursor = Cursors.SizeAll; //SizeAll yapmamımızın amacı taşırken hoş görüntü vermek için
                    ilkkonum = e.Location; //İlk konuma gördüğünüz gibi değerimizi atıyoruz.
        }

        public void storyTasi_MouseMove(object sender, MouseEventArgs e)
        {
                    PictureBox pbSecilen = (sender as PictureBox);
                    if (suruklenmedurumu) // suruklenmedurumu==true ile aynı.
                    {
                        pbSecilen.Left = e.X + pbSecilen.Left - (ilkkonum.X);
                        pbSecilen.Top = e.Y + pbSecilen.Top - (ilkkonum.Y);
                    }
                
            
        }

        public void storyTasi_MouseUp(object sender, MouseEventArgs e)
        {
                    PictureBox pbSecilen = (sender as PictureBox);
                    suruklenmedurumu = false; //Sol tuştan elimizi çektik artık yani sürükle işlemi bitti.
                    pbSecilen.Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini alıyor.
        }

        public void taskTasi_MouseDown(object sender, MouseEventArgs e)
        {
                    PictureBox pbSecilen = (sender as PictureBox);
                    suruklenmedurumu = true; //işlemi burada true diyerek başlatıyoruz.
                    pbSecilen.Cursor = Cursors.SizeAll; //SizeAll yapmamımızın amacı taşırken hoş görüntü vermek için
                    ilkkonum = e.Location; //İlk konuma gördüğünüz gibi değerimizi atıyoruz.
        }

        public void taskTasi_MouseMove(object sender, MouseEventArgs e)
        {
                    PictureBox pbSecilen = (sender as PictureBox);
                    if (suruklenmedurumu) // suruklenmedurumu==true ile aynı.
                    {
                        this.Controls.Add(pbSecilen);
                        pbSecilen.BringToFront();
                        pbSecilen.Left = e.X + pbSecilen.Left - (ilkkonum.X);
                        pbSecilen.Top = e.Y + pbSecilen.Top - (ilkkonum.Y);
                    }
        }

        public void taskTasi_MouseUp(object sender, MouseEventArgs e)
        {
            Color alinanrenk = (sender as PictureBox).BackColor;

            foreach (Task temp in taskListesi)
            {
                if (temp.taskRenk == alinanrenk)
                {
                    PictureBox pbSecilen = (sender as PictureBox);
                    suruklenmedurumu = false; //Sol tuştan elimizi çektik artık yani sürükle işlemi bitti.
                    pbSecilen.Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini alıyor.
                    if ( ( (pbSecilen.Location.X > pnlNotStarted.Location.X) && (pbSecilen.Location.X < (pnlNotStarted.Location.X + pnlNotStarted.Width) ) ) && ((pbSecilen.Location.Y > pnlNotStarted.Location.Y) && (pbSecilen.Location.Y < (pnlNotStarted.Location.Y + pnlNotStarted.Height))) )
                    {
                        temp.taskKategori = "Not Started";
                        this.Controls.Remove(pbSecilen);
                    }
                    else if (((pbSecilen.Location.X > pnlProgress.Location.X) && (pbSecilen.Location.X < (pnlProgress.Location.X + pnlProgress.Width))) && ((pbSecilen.Location.Y > pnlProgress.Location.Y) && (pbSecilen.Location.Y < (pnlProgress.Location.Y + pnlProgress.Height))))
                    {
                        temp.taskKategori = "In Progress";
                        this.Controls.Remove(pbSecilen);
                    }
                    else if (((pbSecilen.Location.X > pnlDone.Location.X) && (pbSecilen.Location.X < (pnlDone.Location.X + pnlDone.Width))) && ((pbSecilen.Location.Y > pnlDone.Location.Y) && (pbSecilen.Location.Y < (pnlDone.Location.Y + pnlDone.Height))))
                    {
                        temp.taskKategori = "Done";
                        this.Controls.Remove(pbSecilen);
                    }
                    else
                    {
                       this.Controls.Remove(pbSecilen);
                    }
                }
            }
            frmTask.taskYenile();
        }

        public void taskBilgiGoster(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Color alinanrenk = (sender as PictureBox).BackColor;
                foreach (Task temp in taskListesi)
                {
                    if (temp.taskRenk == alinanrenk)
                    {
                        MessageBox.Show("TaskID : "+temp.taskID + Environment.NewLine + "Task Kategori : " + temp.taskKategori + Environment.NewLine + "Task Sahibi : " + temp.taskSahibi + Environment.NewLine + "Task Yapım Tarihi : " + temp.taskYapimTarihi + Environment.NewLine + "Task İçeriği : " + temp.taskIcerik,"Task Bilgileri");
                    }
                }
            }
        }

       
    }
}
