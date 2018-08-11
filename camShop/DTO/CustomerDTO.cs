using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        private int _ID;
        private string _FullName;
        private int _Gender;
        private string _Email;
        private string _Address;
        private string _Phone;
        private string _Note;
        private DateTime _CreateAt;
        private string _Img;

        public int ID { get => _ID; set => _ID = value; }
        public string FullName { get => _FullName; set => _FullName = value; }
        public int Gender { get => _Gender; set => _Gender = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public string Note { get => _Note; set => _Note = value; }
        public DateTime CreateAt { get => _CreateAt; set => _CreateAt = value; }
        public string Img { get => _Img; set => _Img = value; }
    }
}
