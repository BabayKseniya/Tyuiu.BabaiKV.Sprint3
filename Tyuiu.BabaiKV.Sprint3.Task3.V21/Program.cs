using Tyuiu.BabaiKV.Sprint3.Task3.V21.Lib;
namespace Tyuiu.BabaiKV.Sprint3.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.Title = "Спринт #3 | Выполнила: Бабай К.В. | СМАРТб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Бабай К.В.  | СМАРТб-24-1                                    *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "f3g5ht g4j 34kg4";
            char item = 'e';
            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Исходный символ = " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Конечная строка = " + ds.ReplaceNumOnChar(value, item));
            Console.ReadKey();
        }
    }
}
