using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_extended
{
    class Program
    {
        
        static void Print1darray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine();
            foreach (int num in arr)
            {
                Console.Write(num + "  ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Print1darray(arr);
            int[] arr2 = { 3,2334,234,232 };
            Print1darray(arr2);


        }
    }
}
