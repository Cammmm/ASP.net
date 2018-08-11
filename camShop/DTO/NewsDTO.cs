using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NewsDTO
    {
        private int _ID;
        private string _Title;
        private string _Content;
        private string _Image;
        private DateTime _CreateAt;

        public int ID { get => _ID; set => _ID = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Content { get => _Content; set => _Content = value; }
        public string Image { get => _Image; set => _Image = value; }
        public DateTime CreateAt { get => _CreateAt; set => _CreateAt = value; }
    }
}
