﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class PostLink
    {
        public int PostId { get; set; }
        public int LinkedPost { get; set; }
    }
}
