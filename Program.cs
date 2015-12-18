using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinputarray
{
    class Program
    {
        static void printarr(int[] arr)
        {
            Console.WriteLine("\n\nElements of array are: \n");
            foreach (int i in arr)
            {
                Console.Write("\t{0}", i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i;

            //loop for accepting value in array
            for (i = 0; i < 5; i++)
            {
                Console.Write("Enter number: \t");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program.printarr(arr);
            //sorting array value
            Array.Sort(arr); //use array sort function

            Program.printarr(arr);
            Console.ReadLine();
        }
    }
}
