﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMapping
{
    public class Person
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public Guid Id { get; set; }
        public string LastName { get; set; }
    }
}