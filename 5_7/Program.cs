using System.ComponentModel.DataAnnotations;

namespace _5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            int max = 0;
            Random rnd = new();
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                max = arr[i, 0];
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(0, 11);
                    Console.Write("{0,2} ",arr[i, j]);
                    if (arr[i, j] > max) max = arr[i, j];
                }
                Console.Write("   Максимум = {0} ", max);
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
