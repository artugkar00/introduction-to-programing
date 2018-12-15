using System;

namespace _02_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            // We get user's name
            string userName;
            Console.WriteLine("hello buddy :) My name is hüdoş. What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine(" Hello "+ userName + " nice to meet you" );

            // We get user's age                                
            int userAge;
            Console.WriteLine("How old are you?");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is "+ userAge);
            respondToAge(userAge);

            // We get user's weight
            double userWeight;
            Console.WriteLine("Please write your weight");
            userWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your weight is "+ userWeight);
            respondToWeight(userWeight);
        }
        static void respondToAge(int age)
        {
            if(age<18) 
            {
                Console.WriteLine("You are too young :)");
            } 
            else if(age>40)
            {
                Console.WriteLine("Oww you are too old :(");
            } 
            else
            {
                Console.WriteLine("Your age is perfect");
            }
        }

        static void respondToWeight(double weight)
        {
            if(weight<60)
            {
                Console.WriteLine("You are too weak");
            }
            else if(weight>90)
            {
                Console.WriteLine("You are too fat");
            }
            else
            {
                Console.WriteLine("Your weight is normal");
            }
        }

    }
}
