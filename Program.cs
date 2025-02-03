// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

public static class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Введите первое");
        // int userInput = int.Parse(Console.ReadLine() ?? string.Empty);
        // Console.WriteLine("Введите второе");
        // int userInput2 = int.Parse(Console.ReadLine() ?? string.Empty);
        // Модификатор_доступа тип_возвращаемого_значения имя_функции(Входные_данные_для_функции){}
        //int result = Sum(userInput, userInput2);
        Sum(7,20).Output();
        Sum(5.10,5.25).Output();
        "Тестим вывод со стринга".Output();
        // Output(result);
    }

    private static int Sum(int a, int b)
    {
        return a + b;
    }
    
    private static double Sum(double a, double b)
    {
        return a + b;
    }
    private static void Output(this int answer)
    {
        Console.WriteLine($"Сложение двух чисел = {answer}");
    }

    private static void Output(this double answer)
    {
        Console.WriteLine($"Сложение двух дробных чисел = {answer}");
    }

    private static void Output(this string answer)
    {
        Console.WriteLine($"Вы написали что-то = {answer}");
    }
}