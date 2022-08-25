namespace BinarySearch
{
    public class IterativeBinarySearch
    {
        int[] arr = new int[] { 1, 2, 3, 4 };
        int first;
        int last;
        int middle;
        int counter = 0;

        public IterativeBinarySearch()
        {
            last = arr.Length - 1;
            first = 0;
            middle = (first + last) / 2;
        }

        public void BinarySearchs(int key)
        {
            while (true)
            {
                Console.WriteLine("-" + counter);

                if (key == arr[middle])
                {
                    counter++;
                    Console.WriteLine(middle);
                    return;
                }
                else if (last == first)
                {
                    Console.WriteLine("Item Not Found!");
                    return;
                }
                else if (key > arr[middle])
                {
                    counter++;
                    first = middle + 1;
                    middle = (first + last) / 2;
                }
                else
                {
                    counter++;
                    last = middle - 1;
                    middle = (first + last) / 2;
                }

            }
        } 
    }
}
