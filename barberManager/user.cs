﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barberManager
{
    class User : Person
    {
        private string uname;
        private string password;
        public User(string password, string uname):base(uname)
        {
            this.password = password;
        }
        string Password { get; set; } //NOTE: access it with objectname.Password
        string Uname { get; set; }

    }
}
