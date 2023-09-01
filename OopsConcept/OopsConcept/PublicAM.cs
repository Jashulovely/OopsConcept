using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class PublicAM
    {
       public void m1()
        {
            Console.WriteLine("public method");
        }
        private void m2()
        {
            Console.WriteLine("private method");
        }
        protected void m3()
        {
            Console.WriteLine("protected method");
        }
        internal void m4()
        {
            Console.WriteLine("internal method");
        }
        protected internal void m5()
        {
            Console.WriteLine("protected internal method");
        }

    }
}
