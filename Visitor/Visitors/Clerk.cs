﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Visitors
{
    public class Clerk : Employee
    {
        public Clerk(): base("Harry", 25000, 15) { }
    }
}
