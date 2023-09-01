using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Program : PublicAM
    {
        static void Main(string[] args)
        {
             //PublicAM pb = new PublicAM();
             Program p = new Program();
             Constr c =new Constr();
            //p.m1();
            //p.m2();
            // p.m3();
            //p.m4();
            //p.m5();
            Constr con = new Constr("jashu",23);
            Constr cons = new Constr("Raju",26,"hyd");
            Constr constr = new Constr("Jashu");
            Constr a = new Constr(23);
            Console.ReadLine();
            
            
            
        }
    }
}
