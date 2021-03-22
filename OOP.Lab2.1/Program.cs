using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP.Lab2._1
{
    public class Time
    {
        public Time() { }
        public Time(int first, int second)
        {
            this.first = first;
            this.second = second;   
        }
        
        private int first;
        private int second;
        public float Minutes()
        {
            return first * 60 + second;
        }
        public void Input()
        {
            string first, second;
            Console.WriteLine("Введіть перше число: ");
            first = Console.ReadLine();
            Console.WriteLine("Введіть друге число: ");
            second = Console.ReadLine();

            bool Isdigit1 = first.Length == first.Where(c => char.IsDigit(c)).Count();
            bool Isdigit2 = second.Length == second.Where(c => char.IsDigit(c)).Count();

            if (Isdigit1 && Isdigit2)
            {
                this.first = Convert.ToInt32(first);
                this.second = Convert.ToInt32(second);
                Console.WriteLine("Ви ввели правильні числа");
            }
            else Console.WriteLine("Числа неправильні");

        }
        public void Display()
        {
            Console.WriteLine($"Кількість хвилин в {this.first} год. i {this.second} хв. = {Minutes()}");
        }
    }

   
    class Program
    {        
        static void Main(string[] args)
        {
            Time time = new Time();
            time.Input();
            time.Minutes();
            time.Display();
        }
    }
}
