using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YazılımYapımıDonemProjesi
{
    public class Story
    {
        public int storyID { get; set; }
        public string stBaslik { get; set; }
        public string stOnemDerecesi { get; set; }
        public int stTahminiSure { get; set; }
        public string stIcerik { get; set; }
        public Color stRenk { get; set; }
    }
}
