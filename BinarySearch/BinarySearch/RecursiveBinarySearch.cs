using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class RecursiveBinarySearch
    {
        int[] arr = new int[] { 10, 22, 32, 43, 53, 65, 73, 81 };
        public void BinarySearch(int key, int first, int last)
        {
            int middle = (first + last) / 2;
            if (arr[middle] == key)
            {
                Console.WriteLine(middle);
            }
            else if (first == last)
            {
                Console.WriteLine("Item Not Found");
            }
            else if (key > arr[middle])
            {
                BinarySearch(key, middle + 1, last);
            }
            else
            {
                BinarySearch(key, first, middle - 1);
            }
        }
    }
}
