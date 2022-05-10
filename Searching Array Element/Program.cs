using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Array_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Enter the value :");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < 7; j++)
            {
                Console.Write(" " + arr[j]);
            }
            Console.WriteLine();
            Console.Write("Enter the search value :");
            int search = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int p = 0; p <7; p++)
            {
                if (arr[p]==search)
                {
                    flag = true;
                    break;

                }

            }
            if (flag==true)
            {
                Console.WriteLine(" Yes found");
            }
            else
            {
                Console.WriteLine("Not found ");
            }
            Console.ReadLine();
            
        }
    }
}
