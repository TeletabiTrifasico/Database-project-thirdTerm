using System;

namespace SomerenModel
{
    public class Student
    {
        public int Id { get; set; }     // database id
        public string Name { get; set; }
        public int Number { get; set; } // StudentNumber, e.g. 474791
        public int Class { get; set; }
        public int PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public Student(){}
        public Student(string Name, int Number)
        {
            this.Name = Name;
            this.Number = Number;
        }
    }
}