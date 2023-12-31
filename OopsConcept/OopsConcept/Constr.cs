﻿using System;
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
        string address;
        public Constr() {
            Console.WriteLine("This is a constructor.");
            Console.WriteLine("This is a constructor.");
            Console.WriteLine("This is a constructor.");
            Console.WriteLine("This is a constructor.");
        }
        public Constr(string name, int age)
        {
            this.name = name;
            Console.WriteLine("Name is " + name +" and age is " + age);
            this.age = age;
            Console.WriteLine("This is a constructor.");
            Console.WriteLine("This is a constructor.");
            Console.WriteLine("This is a constructor.");

        }
        public Constr(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            Console.WriteLine("My Name is " + name + " and age is " + age + " and I am from "+ address);
            Console.WriteLine("This is a constructor.");
            Console.WriteLine("This is a constructor.");
            Console.WriteLine("This is a constructor.");

        }
        public Constr(string name)
        {
            this.name=name;
            Console.WriteLine("My name is " + name);
            Console.WriteLine("This is a constructor.");
            Console.WriteLine("This is a constructor.");
            Console.WriteLine("This is a constructor.");

        }
        public Constr(int age)
        {
            this.age=age;
            Console.WriteLine("I am " +age +" years old.");
            Console.WriteLine("This is a constructor.");
            Console.WriteLine("This is a constructor.");
            Console.WriteLine("This is a constructor.");

        }

    }
}
