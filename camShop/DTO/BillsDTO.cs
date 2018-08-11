using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillsDTO
    {
        private int _ID;
        private int _ID_customer;
        private DateTime _Date_order;
        private double _Total;
        private string _Payment;
        private string _Note;
        private DateTime _Create_at;

        public int ID { get => _ID; set => _ID = value; }
        public int ID_customer { get => _ID_customer; set => _ID_customer = value; }
        public DateTime Date_order { get => _Date_order; set => _Date_order = value; }
        public double Total { get => _Total; set => _Total = value; }
        public string Payment { get => _Payment; set => _Payment = value; }
        public string Note { get => _Note; set => _Note = value; }
        public DateTime Create_at { get => _Create_at; set => _Create_at = value; }
    }
}
