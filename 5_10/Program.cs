using System.Threading.Channels;

namespace _5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool win = false;
            int tryes = 0;
            const int n = 5;
            int[,] arr = new int[n, n];
            Random rnd = new();
            while (!win)
            {
                // заполняем очередную матрицу
                int rows = 0;// сюда суммируем единицы, если равны n, то есть цельная линия = победа
                int cols = 0;// сюда суммируем единицы, если равны n, то есть цельная линия = победа
                int diag1 = 0;// сюда суммируем единицы, если равны n, то есть цельная линия = победа
                int diag2 = 0;// сюда суммируем единицы, если равны n, то есть цельная линия = победа

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = rnd.Next(0, 2);
                    }
                }
                tryes += 1; //+ к счётчику попыток

                // выводим матрицу
                Console.Clear();
                Console.WriteLine("Попытка №{0}", tryes);
                for (int i = 0; i < n; i++)
                {
                    rows = 0;
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0,2} ", arr[i, j]);
                    }
                    Console.WriteLine();
                }

                // проверяем результат
                for (int i = 0; i < n; i++)
                {
                    rows = 0;
                    cols = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j) diag1 += arr[i, j]; // главная диагональ
                        if (i == n - j - 1) diag2 += arr[i, j]; //побочная диагональ
                        if (arr[i, j] == 1) rows += arr[i, j]; // горизонталь
                        if (arr[j, i] == 1) cols += arr[j, i]; // вертикаль
                    }
                    if (rows == n) break;
                    if (cols == n) break;
                }
                if (cols == n || rows == n || diag1 == n || diag2 == n)
                {
                    win = true;
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Давайте попробуем ещё раз (нажмите любую клавишу)");
                Console.ReadKey();
            }
            // повезло
            Console.WriteLine("\n!!!ПОБЕДАААА!!!");
            Console.WriteLine("Попытка №{0} оказалась успешной для 1 (крестики)", tryes);
            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
