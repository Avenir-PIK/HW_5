namespace _5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] arr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = (i + j)%2==0 ? 1 : 0;
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}