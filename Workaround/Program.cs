// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //in-memory data for mask tracking system
            Person person1 = new Person();
            person1.FirstName = "Talha";
            person1.LastName = "Ulutaş";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            SayHello(" Naz");
            SayHello(" Burcu");
            SayHello(" Talha");
            SayHello();

            int result = Sum(6, 58);

            //Arrays
            string[] students = new string[3];
            students[0] = "Naz";
            students[1] = "Burcu";
            students[2] = "Çağla";

            students = new string[4];
            students[3] = "Gizem";

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            //Generic Collections
            List<string> cities = new List<string> { "Ankara", "İstanbul", "İzmir" };
            cities.Add("Adana");
            foreach(var city in cities)
            {
                Console.WriteLine(city);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SayHello(string name = " noname")
        {
            Console.WriteLine("Hello" + name);
        }

        static int Sum(int num1 = 5, int num2 = 10)
        {
            int result = num1 + num2;
            Console.WriteLine("Result : " + result);
            return result;
        }
    }
}



