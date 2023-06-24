using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOpertation1();

            this.BaseOperation2();
            this.Hook1();
            this.RequiredOpertation2();

            this.BaseOperation3();
            this.Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass: BaseOperation1");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass: BaseOperation2");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass: BaseOperation3");
        }

        protected abstract void RequiredOpertation1();

        protected abstract void RequiredOpertation2();

        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}
