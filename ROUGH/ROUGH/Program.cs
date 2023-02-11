using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROUGH
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                arr[i] = j++;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int[] arr2 = new int[20];
            for (int i = 0; i < 20; i++)
            {
                arr2[i] = j++;
            }
            arr = arr2;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
