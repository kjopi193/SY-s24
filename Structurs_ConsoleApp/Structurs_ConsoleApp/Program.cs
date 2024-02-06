using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Structurs_ConsoleApp
{
    internal class Program
    {
        struct pokemon
        {
            public string Name;
            public int Level;
            public int ID;
        }

       
        static void Main(string[] args)
        {
        pokemon pikachu = new pokemon();
            pikachu.Name = "";
            pikachu.Level = 1;
            pikachu.ID = 1;
        student Clark = new student();
            Clark.age = 100;
            Clark.grade = 2;
            Clark.gender = 3;
            Clark.GPA = 3.5;
        }

        struct holiday
        {
            public string name;

        }
        Enum gender { male, female };

        struct student
        {
            public string name;
            public int age;
            public int grade;
            public int gender;
            public decimal GPA;

        }
    }
}
