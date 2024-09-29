using Tyuiu.RyabtsevNE.Sprint1.Task1.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Рябцев Н. Е. | СМАРТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                                ");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 ");
        Console.WriteLine("* Задание #1                                                               ");
        Console.WriteLine("* Вариант #5                                                               ");
        Console.WriteLine("* Выполнил: Рябцев Никита Евгеньевич | СМАРТб-24-1                         ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 ");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные   ");
        Console.WriteLine("* вычисляет результат по формуле (5+(x*y/3)) и печатает его на экране.     ");
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        double x, y;
        Console.WriteLine("* Введите значние х:                                                       ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("* Введите значние y:                                                       ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("*                                                                          ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadKey();
    }
}
