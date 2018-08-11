using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Type_ProductsDTO
    {
        private int _ID;
        private string _Name;
        private string _Descriptions;
        private string _Image;
        private DateTime _CreateAt;

        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Descriptions { get => _Descriptions; set => _Descriptions = value; }
        public string Image { get => _Image; set => _Image = value; }
        public DateTime CreateAt { get => _CreateAt; set => _CreateAt = value; }
    }
}
