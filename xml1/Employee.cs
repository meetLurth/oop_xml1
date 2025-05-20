using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml1
{
    class Employee
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool Porgrammer { get; private set; }

        public Employee (string name, int age, bool porgrammer)
        {
            Name = name;
            Age = age;
            Porgrammer = porgrammer;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
