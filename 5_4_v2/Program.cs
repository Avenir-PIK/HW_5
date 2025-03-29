using System.Globalization;

namespace _5_4_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] arr1 = new int[n];
            Random rnd = new Random();
            //создаём  массив
            Console.WriteLine("\nИсходный массив");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = rnd.Next(0, 11);
                Console.Write("{0} ", arr1[i]);
            }
            //зеркалим массив
            int tmp = 0;
            Console.WriteLine("\nЗеркальный массив");
            for (int i = 0; i < n / 2; i++)
            {
                tmp = arr1[n - i - 1];
                arr1[n - i - 1] = arr1[i];
                arr1[i] = tmp;
            }
            //выводим массив

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr1[i]);
            }

            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
