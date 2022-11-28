using Athlets.Exceptions;
using System.Collections.Generic;

namespace Athlets
{
    internal class Program
    {
        static List<Athlete> LoadFile(string fileName)
        {
            List<Athlete> athletes = new List<Athlete>();
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] items = line.Split();
                if (items[0].CompareTo("Jumper") == 0)
                    athletes.Add(new Jumper(items[1], Convert.ToDouble(items[2])));
                if (items[0].CompareTo("Runner") == 0)
                    athletes.Add(new Runner(items[1], Convert.ToDouble(items[2])));
            }
            return athletes;
        }
        static void Main(string[] args)
        {
            string fileName, action;
            List<Athlete> athletes;

            while (true)
            {
                Console.Clear();
                Console.Write("Введите имя файла: ");
                fileName = Console.ReadLine();
                try
                {
                    athletes = LoadFile(fileName);
                    athletes.Sort();
                    athletes.Reverse();
                    File.WriteAllLines("doping_runner.txt", athletes.Where(o => o.IsOnDoping() && o is Runner).Select(s => s.ToString()).ToList());
                    File.WriteAllLines("doping_jumper.txt", athletes.Where(o => o.IsOnDoping() && o is Jumper).Select(s => s.ToString()).ToList());
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"Файл {fileName} не найден!");
                }
                catch (RunnerTimeOutOfRangeException ex)
                {
                    Console.WriteLine($"Ошибка чтения файла! {ex.Message}");
                }

                Console.WriteLine("Обработать ещё файлы? y/n");
                action = Console.ReadLine();
                if (action.Trim() == "n")
                    break;
            }






        }
    }
}