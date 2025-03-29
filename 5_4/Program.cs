namespace _5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            Random rnd = new Random();
            //Отдельно создаём и выводим массив
            Console.WriteLine("\nИсходный массив");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = rnd.Next(0, 11);
                Console.Write("{0} ", arr1[i]);
            }
            /*Отдельно создаём второй массив и заполняем зеркально первому
            Хотя можно при генерации зополнять сразу два массива с разных концов, но это некорректно.
            */
            Console.WriteLine("\nЗеркальный массив");
            for (int i = 0; i < n; i++)
            {
                arr2[i] = arr1[n-i-1];
                Console.Write("{0} ", arr2[i]);
            }


            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
