using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If you wanna have all same numbers again and again then puts seed in it...
            Random random = new Random();

            //for(int i = 0; i < 10; i++)
            //{
            //    // Next method will give us 10 different random numbers.
            //    Console.WriteLine(random.Next()); 
            //    Console.Write("------------------------------------");
            //    // NextDouble method will give us 10 different numbers between 0.00 and 1.00
            //    Console.WriteLine(random.NextDouble());
            //    // To use random class properly, do not instantaite it again and again... Use functions
            //    SimpleMethode(random);
            //}
            List<PersonModel> people = new List<PersonModel> { 
            new PersonModel{firstName="Seth"},
            new PersonModel{firstName="Rain"},
            new PersonModel{firstName="Feyza"},
            new PersonModel{firstName="Metin"},
            new PersonModel{firstName="Ali"},
            new PersonModel{firstName="Sezai"},
            new PersonModel{firstName="Hamiyet"},
            new PersonModel{firstName="Turgut"},
            new PersonModel{firstName="Eda"},
            new PersonModel{firstName="Hilmi"},
            };
            // This usage sorts by name...
            var sortedPeople = people.OrderBy(x => x.firstName);
            // If you wanna sort these names by random numbers then use random.next
            var sortedPeople2 = people.OrderBy(x => random.Next());

            // looping them...
            foreach (var p in sortedPeople)
            {
                // Order by name
                Console.WriteLine(p.firstName);
               
            }
            Console.WriteLine("----------------------------------------");
            foreach (var p in sortedPeople2)
            {
                // Order by random.next
                Console.WriteLine(p.firstName);
            }
            Console.ReadLine();
        }

        private static void SimpleMethode(Random random)
        {
            // If you wanna have a range and put numbers.. I wanna numbers between 1 and 10
            Console.WriteLine(random.Next(1,10));
            // Or you can have this code piece as random.Next(11); Same thing...
        }
        public class PersonModel
        {
            public string firstName { get; set; }
        }
    }
}
