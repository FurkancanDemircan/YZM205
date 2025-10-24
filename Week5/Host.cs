using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Host : Person
    {
        public string Expertise { get; set; }

        public Host(int id, string name, string expertise) : base(id, name)
        {
            Expertise = expertise;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Expertise}";
        }
    }
}
