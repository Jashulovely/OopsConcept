using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Constr
    {
        //constructor is a special method of a class that is automatically invoked when an
        // instance of a class is created.
        //constructor has exactly as the same name as class name and does not have any return type.

        //Default constructor which is not parameterised.
        string name ;
        int age;
        public Constr() {
            Console.WriteLine("This is a constructor.");
        }
        public Constr(string name, int age)
        {
            this.name = name;
            Console.WriteLine("Name is " + name +" and age is " + age);
            this.age = age;
            
        }
        
    }
}
