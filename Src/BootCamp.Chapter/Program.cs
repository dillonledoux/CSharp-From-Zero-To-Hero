using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            float age, weight, height;

            Console.WriteLine("BMI Generator");
            Console.WriteLine("What's the person's first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("Whats his last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("Whats his age?");
            age = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Whats his weight in kg?");
            weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Whats his height in cm?");
            height = Convert.ToSingle(Console.ReadLine());

            //https://www.cdc.gov/nccdphp/dnpao/growthcharts/training/bmiage/page5_1.html
            float bmi = (weight / height / height) * 10000;

            Console.WriteLine(firstName+ " " +lastName+ " is " +age+ " years old, his weight is " +weight+ " kg and his height is " +height+ " cm.");
            Console.WriteLine("His BMI is " +Math.Round(bmi,1)+ ".");
        }
    }
}
