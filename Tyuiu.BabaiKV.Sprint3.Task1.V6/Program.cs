using Tyuiu.BabaiKV.Sprint3.Task1.V6.Lib;
namespace Tyuiu.BabaiKV.Sprint3.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int value = 4;
            int startValue = 1;
            int endValue = 10;

            Console.Title = "Спринт #3 | Выполнила: Бабай К.В. | СМАРТб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Бабай К.В.  | СМАРТб-24-1                                    *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Перемнная А  = " + value);
            Console.WriteLine("Начало шага = " + startValue);
            Console.WriteLine("Конец шага = " + endValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма равна : " + ds.GetSumSeries(value, startValue, startValue));
            Console.ReadKey();
        }
    }
}
