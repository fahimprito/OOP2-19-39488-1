using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int cc=1, ctr=0;
            int[] arr1 = new int[] { 2, 3, 3, 5, 6 };
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];// { 2, 2, 6, 5, 5, 4, 4, 3 };

            Console.WriteLine("Values of the array are : \n");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            Console.WriteLine("\nArray in reverse order:\n");
            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.WriteLine(" ");

            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
            }
            Console.WriteLine("Sum of all elements of the array {0}", sum);
            Console.WriteLine(" ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.Write("First array : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\nCopy array : ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.WriteLine(" ");

            //duplicate
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = cc;
                        cc++;
                    }
                }
                cc = 1;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr3[i] == 2)
                {
                    ctr++;
                }
            }
            Console.WriteLine("Duplicate elements are: {0}", ctr);
            Console.WriteLine(" ");

            //unique
            for (int i = 0; i < arr1.Length; i++)
            {
                int unique = 0;
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        unique = 1;

                    }
                    if (arr1[i] == arr1[i + 1])
                    {
                        i++;
                    }


                }
                if (unique == 0)
                {
                    Console.WriteLine("unique number: {0}", arr1[i]);
                }
            
            }
        }
    }
}
