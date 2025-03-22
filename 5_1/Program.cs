namespace _5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100]. Определить, каких чисел больше – четных или нечетных");

            const int n = 10;
            int[] pachka = new int[n];

            Random rnd = new Random();
            int chet = 0;

            for (int i = 0; i < n; i++)
            {
                pachka[i] = rnd.Next(0, 101);
                if (pachka[i] % 2 == 0) chet++;
                Console.Write("{0} ", pachka[i]);
            }

            Console.WriteLine("\nчётных чисел тут {0}", chet);
            if (chet == 5) Console.WriteLine("\nчётных и нечётных одинаково", chet);
            if (chet < 5) Console.WriteLine("\nчётных меньше", chet);
            else Console.WriteLine("\nчётных больше", chet);

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
