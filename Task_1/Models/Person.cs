using System;
namespace Task_1.Models
{
    public class Person
    {
        private int _age;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 160)
                {
                    _age = value;
                }
            }
        }


        public Person(string name,string surname,int age)
        {
            this.Name = name;
            this.SurName = surname;
            this.Age = age;
        }
       
    }     
}
