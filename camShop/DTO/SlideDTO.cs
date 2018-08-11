using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class SlideDTO
    {
        private int _ID;
        private string _Link;
        private string _Image;

        public int ID { get => _ID; set => _ID = value; }
        public string Link { get => _Link; set => _Link = value; }
        public string Image { get => _Image; set => _Image = value; }
    }
}
