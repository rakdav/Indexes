using System;
using System.Collections.Generic;
using System.Text;

namespace Indexes
{
    class Person
    {
        public enum Status
        {
            ребенок,школьник,студент,работник, пенсионер
        }
        public enum Health
        {
            здоров, нездоров, покатит
        }
        private string fam="";
        private int age;
        private int salary;
        private Status status = Status.работник;
        private Health health = Health.здоров;
        private const int Max_Children = 20;
        private Person[] children = new Person[Max_Children];
        private int count_children = 0;
        public int Count_children
        {
            get { return count_children; }
        }

        public Person this[int i]
        {
            get
            {
                if (i >= 0 && i < count_children) return children[i];
                else return children[0];
            }
            set
            {
                if(i==count_children&&i<Max_Children)
                {
                    children[i] = value;
                    count_children++;
                }
            }
        }
        public string Fam
        {
            get { return fam; }
            set { if (fam=="") fam = value; }
        }
        public Status GetStatus
        {
            get
            {
                return status;
            }
        }
        public Health GetHealth
        {
            get
            { return health;}
        }

        public int Age
        {
            set
            {
                age = value;
                if (age < 7) status = Status.ребенок;
                else if (age < 17) status = Status.школьник;
                else if (age < 22) status = Status.студент;
                else if (age < 65) status = Status.работник;
                else status = Status.пенсионер;
            }
            get { return age; }
        }

        public int Salary
        {
            set { salary = value; }
        }

    }
}
