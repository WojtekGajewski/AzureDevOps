using C10Inheritence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Implicit casting : 

            Programmer programmer = new Programmer();
            Person person = new Person();

            Person person1 = programmer; // implict casting from programmer to person 


            programmer.TestingAccessor = "ok";
            //explicit casting:
            Person person2 = new Person();
            // Programmer programmer2 = (Programmer)person2;
            // this throws an exception


            // Person person3 = new Person();
            //  Person person3 = new Programmer();
            Person person3 = new Doctor();

            if (person3 is Programmer)
            {
                Programmer programmer3 = (Programmer)person3;
            }
            else
            {
                Console.WriteLine("The person object cannot be cast to a programmer");
            }

            Person[] people = new Person[4];

            people[0] = new Programmer { Name = "Alice", Age = 30, ProgrammingLanguage="C#" };
            people[1] = new Doctor { Name = "Bob", Age = 45, Specialization= "Cardiology" };
            people[2] = new Programmer { Name = "Charlie", Age = 30, ProgrammingLanguage="Python" };
            people[3] = new Doctor { Name = "David", Age = 45, Specialization="Neurology" };

            foreach (var personx in people)
            {
                Console.WriteLine($"Name: {personx.Name}, Age: {personx.Age}");
                
                if(personx is Programmer)
                {
                    Programmer p = (Programmer)personx;
                    Console.WriteLine($"Programmin language: {p.ProgrammingLanguage}");
                }else if (personx is Doctor)
                {
                    Doctor p = (Doctor)personx;
                    Console.WriteLine($"specialization : {p.Specialization}");
                }
            }
        }
    }
}
