using System;

namespace _04_smallest_number
{
    class Program
    {
        static void Main(string[] args)
    
         { 
            int size;
            Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
              
              Console.WriteLine("Enter the array elements");
              array [i] = Convert.ToInt32(Console.ReadLine());
            }
            int number = array [0];
            for (int i = 0; i < number; i++);
            
               if (array[0] < number)
               number= array[0];
               Console.WriteLine("Smallest number {0}", number);
               Console.ReadLine();
        
         }  
    }
}