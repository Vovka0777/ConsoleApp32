using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp32
{
    internal class Abiturient : Persona
    {

        public Abiturient(string name, DateTime data, string facult, int age) : base(name, data, facult, age)
        {
            this.Name = name;
            this.Data = data;
            this.Facult = facult;
            this.Age = age;
        }

        public static Abiturient Enter()
        {
         Console.Clear();
         Console.Write("Введите имя - ");
         string name = Console.ReadLine();
         Console.Write("Введите дату - ");
         DateTime data = DateTime.Parse(Console.ReadLine());
         Console.Write("Введите факультет - ");
         string facut = Console.ReadLine();
         Console.Write("Введите возраст - ");
         int age = int.Parse(Console.ReadLine());

         return new Abiturient(name, data, facut, age);
        }

        public override void Info()
        {
            Console.WriteLine($"Имя: {Name}\nДата рождения: {Data}\nФакультет: {Facult}\nВозраст: {Age}");
        }

    }

}

