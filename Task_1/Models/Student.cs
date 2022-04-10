using System;
namespace Task_1.Models
{
    public class Student : Person
    {
        private int _point;
        public int Id { get; set; }
        public int Point
        {
            get { return _point; }
            set
            {
                if (value > 0 && value < 100)
                {
                    _point = value;
                }
            }
        }

        public Student(string name, string surname, int age, int id, int point) : base(name, surname,age)
        {
            this.Point = point;
            this.Id = id;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}\nSurname:{SurName}\nAge:{Age}\nStudentId:{Id}\nPoint:{Point}");
        }
    }
}
