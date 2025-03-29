namespace _5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] arr = new int[n];
            Random rnd = new Random();

            //Отдельно создаём и выводим массив
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 51);
                Console.Write("{0} ", arr[i]);
            }
            int max = arr[0];
            int max_ind = 0;
            int min = arr[0];
            int min_ind = 0;
            //Обрабатываем отдельно
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    min_ind = i;
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                    max_ind = i;
                }
            }
            Console.WriteLine("\n\nМаксимальное = {0} с индексом {1}", max, max_ind);
            Console.WriteLine("\nМинимальное = {0} с индексом {1}", min, min_ind);
            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
