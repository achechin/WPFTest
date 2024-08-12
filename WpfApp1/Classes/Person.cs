using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    class Person
    {
        public string name;
        public int age;

        //Конструктор
        public Person()
        {
            Debug.WriteLine("Создание объекта person");
            name = "Oleg";
            age = 34;
        }

        public void Print()
        {
            Console.WriteLine(name,age);
        }
    }
}
