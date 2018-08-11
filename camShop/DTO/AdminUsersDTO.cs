using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class AdminUsersDTO
    {
        private int _ID;
        private string _Username;
        private string _Password;
        private string _AdminUsers;
        private string _Email;
        private string _Remember_token;
        private string _Fullname;
        private string _Img;
        private DateTime _Create_at;

        public int ID { get => _ID; set => _ID = value; }
        public string Username { get => _Username; set => _Username = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string AdminUsers { get => _AdminUsers; set => _AdminUsers = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Remember_token { get => _Remember_token; set => _Remember_token = value; }
        public string Fullname { get => _Fullname; set => _Fullname = value; }
        public string Img { get => _Img; set => _Img = value; }
        public DateTime Create_at { get => _Create_at; set => _Create_at = value; }
    }
}
