using System;

namespace _04_smallest_number
{
    class Program
    {
        static void Main(string[] args) { 
            int size;
            Console.WriteLine("Enter the size of array:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            for(int i = 0; i < size; i++) {
              Console.WriteLine("Enter " + i + ". element:");
              array[i] = Convert.ToInt32(Console.ReadLine());
            }
         
            // finding minimum algorithm
            int minIndex = 0;
            int min = array[0];
            for(int i = 1; i < size; i++) {
               if(array[i] < min) {
                  min = array[i];
                  minIndex = i;
               }
            } 
            
            Console.WriteLine("Smallest number={0}, smallest index={1}", min, minIndex);

            // finding maximum algorithm
            int maxIndex = 0;
            int max = array[0];
            for(int i = 1; i < size; i++) {
               if(array[i] > max) {
                  max = array[i];
                  maxIndex = i;
               }
            } 

            Console.WriteLine("Biggest number {0}, biggest index={1}", max, maxIndex);
            Console.ReadLine();
         }  
    }
}