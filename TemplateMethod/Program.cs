﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client.ClientCode(new ConcreteClass1());

            Client.ClientCode(new ConcreteClass2());
        }
    }
}
