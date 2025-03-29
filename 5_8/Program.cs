namespace _5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[] arr = new int[n];
            Random rnd = new Random();

            //Создали массив
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 11);
                Console.Write("{0} ", arr[i]);
            }

            int max = -1; // начальные значения вне диапазона допустимых в меньшую сторону
            int premax = -1;

            //Обработали массив
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    premax = max;
                    max = arr[i];
                }
                else if (arr[i] > premax) premax = arr[i];

            }

            Console.Write("\n{0,2} - max", max);
            Console.Write("\n{0,2} - premax", premax);
            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
