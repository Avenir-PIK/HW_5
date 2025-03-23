using System.Runtime.ExceptionServices;

namespace _5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 4;
            const int m = 5;
            //формируем матрицу из нулей
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = 0;
                }
            }
            //заполняем матрицу (решал такую задачу год назад на "поколение python курс для продвинутых" на степике (4.6, шаг 10) )
            int x = 0;
            int y = 0; // реальные координаты
            int dx = 0;
            int dy = 1; // шагаем по Х или У
            int mx = 0;
            int my = 0; // будущие кординаты (проверяем их на всё, перед передачей в реальные)

            for (int i = 0; i < (n * m); i++) // всего шагов = количество полей матрицы
            {
                arr[x, y] = i+1;
                mx = x + dx;
                my = y + dy;
                if ((mx < n && mx >= 0) && (my < m && my >= 0))
                {
                    x = mx;
                    y = my;
                }

            }
            //выводим матрицу
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,2} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}