using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Person
    {
        private int Id { get; set; }
        private string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string? ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
