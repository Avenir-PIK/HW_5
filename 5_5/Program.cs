namespace _5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] arr = new int[n];
            Random rnd = new Random();
            //Отдельно создаём и выводим массив
            Console.WriteLine("\nИсходный массив");
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-50, 51);
                Console.Write("{0} ", arr[i]);
            }

            //Первые пять

            Console.WriteLine("\nОтсортированный массив");
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                for (int j = i + 1; j < (n / 2) - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            // Вторые пять
            for (int i = 5; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            //Отдельно выводим массив
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
