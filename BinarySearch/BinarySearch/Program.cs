using BinarySearch;

Console.Write("Key : ");
int key = Convert.ToInt32(Console.ReadLine());

do 
{
    RecursiveBinarySearch x = new RecursiveBinarySearch();
    x.BinarySearch(key, 0, 9);

    Console.WriteLine("-----------------------------");

    IterativeBinarySearch a = new IterativeBinarySearch();
    a.BinarySearchs(key);


    Console.Write("Key : ");
    key = Convert.ToInt32(Console.ReadLine());

} while (key != -50);