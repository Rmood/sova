﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Creation_date { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
    }
}
