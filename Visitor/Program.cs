﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitors;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees e1 = new Employees();
            e1.Attach(new Clerk());
            e1.Attach(new Director());

            e1.Accept(new IncomeVisitor());
            e1.Accept(new VacationVisitor());

            var x = Average(2, 1);
            Console.WriteLine(x);

            Console.ReadKey();
        }

        public static double Average(int a, int b)
        {
            var c = (a + b);
            var d = (double)c/2;
            return  d;
        }
    }
}



