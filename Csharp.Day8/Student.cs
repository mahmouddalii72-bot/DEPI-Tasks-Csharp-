using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Csharp.Day8
{
    class Address
    {
        public string City { get; set; }

        public Address(string city)
        {
            City = city;
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

        // Constructor عادي
        public Student(int id, string name, Address address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        // Copy Constructor (Deep Copy)
        public Student(Student other)
        {
            Id = other.Id;
            Name = other.Name;
            Address = new Address(other.Address.City); // Deep Copy
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, City: {Address.City}");
        }

    }
}
