using OopsConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Program : PublicAM
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.m1();
            p.m3();
            p.m5();
            Console.WriteLine("Methods accessed by Access Modifiers");
            Console.ReadLine();

        }
    }
}
