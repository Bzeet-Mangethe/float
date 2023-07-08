using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1Assessment2
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person("John");
            Person person2 = new Person("John");

            // Using the == operator
            bool isEqualOperator = person1 == person2;
            Console.WriteLine("Using == operator: " + isEqualOperator);
            // Output: Using == operator: False

            // Using the Object.Equals method
            bool isEqualEqualsMethod = person1.Equals(person2);
            Console.WriteLine("Using Object.Equals method: " + isEqualEqualsMethod);
            // Output: Using Object.Equals method: False

            // Using the Object.ReferenceEquals method
            bool isEqualReferenceEqualsMethod = ReferenceEquals(person1, person2);
            Console.WriteLine("Using Object.ReferenceEquals method: " + isEqualReferenceEqualsMethod);
            // Output: Using Object.ReferenceEquals method: False

        }
    }
}
