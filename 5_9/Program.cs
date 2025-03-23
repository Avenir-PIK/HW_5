using System.Runtime.ExceptionServices;

namespace _5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
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
            int x = 0;

            //решал такую задачу год назад на "поколение python курс для продвинутых" на степике (4.6, шаг 10)
            //решал такую задачу год назад на "поколение python курс для продвинутых" на степике (4.6, шаг 10)
            //решал такую задачу год назад на "поколение python курс для продвинутых" на степике (4.6, шаг 10)

            int y = 0; // реальные координаты
            int dx = 0;
            int dy = 1; // шагаем по Х или У
            //int mx = 0;
            //int my = 0; // перенёс внутрь цикла, чтобы память не кушали

            for (int i = 0; i < (n * m); i++) // всего шагов = количество полей матрицы
            {
                arr[x, y] = i+1;
                int mx = x + dx;
                int my = y + dy; // будущие кординаты (проверяем их на всё, перед передачей в реальные)
                if ((mx < n && mx >= 0) && (my < m && my >= 0) && arr[mx,my]==0) //в рамках размера матирцы и слудующее поле равно "0", так как если не "0", то не заполняем а поворачиваем
                {
                    x = mx;
                    y = my; 
                }
                else //если край или уперлись в заполненное - поворачиваем
                {
                    int temp = dx;
                    dx = dy;
                    dy= -temp; // минус - важен для поворотов (чтобы идти в обратную сторону через раз по одному направлению) !!!
                    x += dx;
                    y += dy;
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