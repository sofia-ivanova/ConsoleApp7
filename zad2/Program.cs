namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 5, 9, 10, 5, 11 };
            Console.WriteLine("Write target:");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number {target} is at index {Search(array, target)}");
            Console.ReadKey();
        }
        static int Search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    int a = array[i];
                    for (int j = i; j > 0; j--)
                    {
                        array[j] = array[j - 1];
                    }
                    array[0] = a;
                    return i;
                }
            }
            return -1;
        }
    }
}
