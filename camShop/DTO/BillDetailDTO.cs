using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class BillDetailDTO
    {
        private int _ID;
        private int _ID_bill;
        private int _ID_product;
        private int _quantity;
        private double _Unit_price;
        private DateTime _CreateAt;

        public int ID { get => _ID; set => _ID = value; }
        public int ID_bill { get => _ID_bill; set => _ID_bill = value; }
        public int ID_product { get => _ID_product; set => _ID_product = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public double Unit_price { get => _Unit_price; set => _Unit_price = value; }
        public DateTime CreateAt { get => _CreateAt; set => _CreateAt = value; }
    }
}
