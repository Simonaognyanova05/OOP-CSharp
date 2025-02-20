﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsList___WFA
{
    internal class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber {  get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Phone Number: {PhoneNumber}, Email: {Email}";
        }
    }
}
