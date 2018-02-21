using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSorting
{
    class Program
    {
        static string[] bigSorting(string[] arr)
        {
            // Complete this function
            return arr.OrderBy(l => Convert.ToDouble(l)).ToArray();
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int arr_i = 0; arr_i < n; arr_i++)
            {
                arr[arr_i] = Console.ReadLine();
            }
            string[] result = bigSorting(arr);
            Console.WriteLine(String.Join("\n", result));

            Console.ReadLine();
        }
    }
}
