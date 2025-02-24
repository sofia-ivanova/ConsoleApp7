namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 5, 9, 10, 5, 11};
            Console.WriteLine("Write target:");
            int target = int.Parse(Console.ReadLine());
            (int count, List<int> list) = Search(array, target);
            Console.WriteLine($"The number {target} is there {count} times");
            Console.WriteLine("positions: " + (list.Count > 0 ? string.Join(", ", list) : "No elements found"));
            Console.ReadKey();
        }
        static (int, List<int>) Search(int[]array, int target)
        {
            List<int> list = new List<int>();
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    list.Add(i);
                    count++;
                }
            }
            return (count, list);

        }
    }
}
