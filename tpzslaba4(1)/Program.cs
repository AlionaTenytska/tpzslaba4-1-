using System;
using System.IO;
using System.Linq;

namespace tpzslaba4_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            char[] symbol = { ' ', ',', '.', '!', '?', ':', ';', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            using (StreamReader MyFile = new StreamReader("input.txt"))
            {
                // читання рядка з файлу, поки це можливо
                while ((line = MyFile.ReadLine()) != null)
                {
                    Console.WriteLine("Строка символов с файла: ");
                    Console.WriteLine(line); //друкуємо рядок
                    string result = string.Concat(line.Split(symbol, StringSplitOptions.RemoveEmptyEntries).Select(word => word.Last()));
                    Console.WriteLine("Искаемая строка: ");
                    Console.WriteLine(result);//друкуємо результат
                }
            }
            Console.ReadLine();

        }
    }
}
