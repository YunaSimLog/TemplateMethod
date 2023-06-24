using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOpertation1()
        {
            Console.WriteLine("ConcreteClass1 : RequiredOpertation1");
        }

        protected override void RequiredOpertation2()
        {
            Console.WriteLine("ConcreteClass1 : RequiredOpertation2");
        }
    }

    class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOpertation1()
        {
            Console.WriteLine("ConcreteClass2 : RequiredOpertation1");
        }

        protected override void RequiredOpertation2()
        {
            Console.WriteLine("ConcreteClass2 : RequiredOpertation2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2 : Hook1");
        }
    }
}
