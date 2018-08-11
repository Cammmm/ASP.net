using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ProductsDTO
    {
        private int _ID;
        private string _Name;
        private int _ID_type;
        private string _Description;
        private float _Unit_price;
        private float _Promotion_price;
        private string _Image;
        private string _Unit;
        private DateTime _CreatAt;

        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public int ID_type { get => _ID_type; set => _ID_type = value; }
        public string Description { get => _Description; set => _Description = value; }
        public float Unit_price { get => _Unit_price; set => _Unit_price = value; }
        public float Promotion_price { get => _Promotion_price; set => _Promotion_price = value; }
        public string Image { get => _Image; set => _Image = value; }
        public string Unit { get => _Unit; set => _Unit = value; }
        public DateTime CreatAt { get => _CreatAt; set => _CreatAt = value; }
    }
}
