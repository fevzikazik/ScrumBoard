using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YazılımYapımıDonemProjesi
{
    public class Task
    {
        public int taskID { get; set; }
        public int taskStID { get; set; }
        public string taskKategori { get; set; }
        public string taskSahibi { get; set; }
        public DateTime taskYapimTarihi { get; set; }
        public string taskIcerik { get; set; }
        public Color taskRenk { get; set; }
    }
}
