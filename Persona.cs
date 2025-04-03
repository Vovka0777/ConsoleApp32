using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    abstract class Persona
    {
        private string name;
        private DateTime data;
        private string facult;
        private int age;

        public string Name { get => name; set => name = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Facult { get => facult; set => facult = value; }
        public int Age { get => age; set => age = value; }

        public Persona (string name, DateTime data, string facult, int age)
        {
            this.name = name;
            this.data = data;
            this.facult = facult;
            this.age = age;
        }
        public abstract void Info();

    }
}
