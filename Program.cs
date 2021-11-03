using System;
using System.Collections.Generic;
using System.Linq;
using linqdemo.Models;

namespace linqdemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Person> people = RepositoryPerson.Persons();

            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"Person is {person.ID}");
            //}

            //
            Person p1 = people.Where(x => x.ID == 1).First();

            Console.WriteLine($"Person is {p1.Name}");

            //
            Person p31 = people.Where(x => x.ID == 31).FirstOrDefault();

            if (p31 == null)
            {
                Console.WriteLine("Person is not found");
            }
            else
            {
                Console.WriteLine($"Person is {p1.Name}");
            }

            //
            List<Person> listBelow5k = people.Where(x => x.Salary <= 50000).ToList();

            foreach (Person person in listBelow5k)
            {
                Console.WriteLine($"Person ID is {person.ID} and earns {person.Salary}");
            }

            int countIreland = people.Where(x => x.Address == "Ireland").Count();

            Console.WriteLine($"{countIreland} people live in Ireland");

            IEnumerable<string> result = from p1 in people where p1.Name.Length > select
        }
    }
}