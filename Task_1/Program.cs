using System;
using Task_1.Models;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int point;
            Console.WriteLine("Ad daxil edin");
            string name = Console.ReadLine();

            Console.WriteLine("Soyad daxil edin");
            string surname = Console.ReadLine();

            
            
            do
            {
                Console.WriteLine("Age daxil edin");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (age<0);
            

            Console.WriteLine("Id daxil edin");
            int id = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Point daxil edin");
                point = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (point<0 || point>100);


            Student stu1 = new Student(name, surname, age, id, point);
            stu1.ShowInfo();
        }
    }
}
