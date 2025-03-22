namespace _5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] arr = new int[n];
            Random rnd = new Random();
            int minus = 0;
            int plus = 0;
            int zero = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-20, 21);
                Console.Write("{0} ", arr[i]);
                if (arr[i] == 0) zero++;
                else if (arr[i] < 0) minus++;
                else plus++;
            }
            Console.WriteLine("\n{0} положительных элементов\n{1} отрицательных элементов\n{2} равных нулю элементов", plus, minus, zero);
            Console.ReadKey();
        }
    }
}
