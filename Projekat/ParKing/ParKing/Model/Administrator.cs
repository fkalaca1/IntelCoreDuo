﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    class Administrator : User
    {
        public Administrator(string email, string brojTelefona, string sifra) : base(email, brojTelefona, sifra)
        {
        }
    }
}