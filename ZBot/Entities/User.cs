﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZBot.Entities
{
    public class User
    {
        public int UserId { get; set; } 

        public string Email { get; set; }

        public string Username { get; set; }

        public Token Token { get; set; }
    }
}
