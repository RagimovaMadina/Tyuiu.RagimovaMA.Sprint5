using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.RagimovaMA.Sprint5.Task2.V13.Lib;

namespace Tyuiu.RagimovaMA.Sprint5.Task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3] { { 7, 6, 5 },
                                          { 7, 7, 8 },
                                          { 6, 6, 9 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            Console.Title = "Спринт #5 | Выполнила: Рагимова М. А. | СМАРТб-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Рагимова Мадина Абдулакимовна | СМАРТб-23-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
            Console.WriteLine("* 7; 6; 5                                                                 *");
            Console.WriteLine("* 7; 7; 8                                                                 *");
            Console.WriteLine("* 6; 6; 9                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            using (StreamReader reader = new StreamReader(res))
            {
                Console.WriteLine("\nМассив после замены: ");
                for (int i = 0; i < rows; i++)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(';');
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{Convert.ToInt32(values[j])} \t");
                    }
                    Console.WriteLine();
                }
            }



            Console.ReadKey();
        }
    }
}
