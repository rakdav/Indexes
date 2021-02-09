using System;

namespace Indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Fam = "Иванов Петр Ильич";
            person1.Age = 27;
            Person person2 = new Person();
            person2.Fam = "Иванов Илья Петрович";
            person2.Age = 3;
            person1[person1.Count_children] = person2;
            Person person3 = new Person();
            person3.Fam = "Иванова Анна Петровна";
            person3.Age = 1;
            person1[person1.Count_children] = person3;
            Print(person1);
            Print(person1[0]);
            Print(person1[1]);
            Console.WriteLine(person1.Count_children);
        }
        static void Print(Person p)
        {
            Console.WriteLine("Фамилия:{0}, возраст:{1}, статус:{2}",
                p.Fam,p.Age,p.GetStatus);
        }
    }
}
