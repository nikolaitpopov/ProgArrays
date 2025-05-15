using System;

class Program
{
    static void Main()
    {
        // Получаем размеры массива
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        // Создаем двумерный массив
        int[,] array = new int[rows, cols];

        // Ввод элементов массива
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Введите {cols} чисел для строки {i + 1}: ");
            string[] input = Console.ReadLine().Split();
            if (input.Length != cols)
            {
                Console.WriteLine($"Ошибка: нужно ввести ровно {cols} чисел!");
                return;
            }
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = int.Parse(input[j]);
            }
        }

        // Сортировка каждой строки по убыванию
        for (int i = 0; i < rows; i++)
        {
            int[] row = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                row[j] = array[i, j];
            }
            Array.Sort(row);
            Array.Reverse(row);
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = row[j];
            }
        }

        // Вывод отсортированного массива
        Console.WriteLine("\n Отсортированный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}