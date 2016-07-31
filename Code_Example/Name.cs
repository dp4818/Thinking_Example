using System;
using System.Collections.Generic;

using System.Text;

namespace Code_Example
{
    class Name
    {
        string givenName;
        string surname;
        public Name(string givenName, string surname)
        {
            this.givenName = givenName;
            this.surname = surname;
        }
        public bool perhapsRelated(string surname)
        {
            return this.surname == surname;
        }
        public void printGivenName()
        {
            /* Legal, but unwise */
            string givenName = "method variable";
            System.Console.WriteLine("givenName is: " +
            givenName);
            System.Console.WriteLine("this.givenName is: "
            + this.givenName);
        }/*
        public static void Main()
        {
            Name vanGogh = new Name("Vincent", "vanGogh");
            vanGogh.printGivenName();
            bool b = vanGogh.perhapsRelated("vanGogh");
            if (b)
            {
                System.Console.WriteLine("He's a vanGogh.");
            }
            Console.ReadLine();
        }*/
    }
}

