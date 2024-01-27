using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name) { 
        
            this.Name = name;
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person otherPerson = (Person)obj;
            return Name == otherPerson.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }


    }
}
