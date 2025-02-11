// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
namespace CharpDops
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            #region Hello GAYS
            // Console.WriteLine("Введите первое");
            // int userInput = int.Parse(Console.ReadLine() ?? string.Empty);
            // Console.WriteLine("Введите второе");
            // int userInput2 = int.Parse(Console.ReadLine() ?? string.Empty);
            // Модификатор_доступа тип_возвращаемого_значения имя_функции(Входные_данные_для_функции){}
            //int result = Sum(userInput, userInput2);
            // Output(result);
            //ArifmeticOperation operation = new(5,2,3,true);
            //Console.WriteLine(gg);
            //ConsoleOutput output = new ConsoleOutput();
            //int gg = operation.Sum(1, 2);
            //output.Output(gg);
            #endregion
            Console.WriteLine("Введите первое");
            int userInput = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введите второе");
            int userInput2 = int.Parse(Console.ReadLine() ?? string.Empty);

            ConsoleOutput output = new ConsoleOutput(userInput, userInput2);
            output.WriteAll();

            
        }
        #region GG
        //class ArifmeticOperation
        //{
        //    private int _a;
        //    private int A;
        //    private int B;
        //    //public int A { 
        //    //    get { 
        //    //        return A; 
        //    //    } 
        //    //    set 
        //    //    {
        //    //        if (value == 5)
        //    //        {
        //    //            Console.WriteLine("Еблан?");
        //    //        }
        //    //        else 
        //    //        {
        //    //            A = value;
        //    //        }
        //    //    } 
        //    //}

        //    public ArifmeticOperation(int a, int b, double c, bool isEqual)
        //    {
        //        A = a;
        //        B = b;
        //    }

        //    public override string ToString()
        //    {
        //        return $"Сложение a + b = {A + B}";
        //    }
        //    public int Sum(int a, int b)
        //    {
        //        return a + b;
        //    }

        //    public int getA()
        //    {
        //        return A;
        //    }
        //    public void setA(int a)
        //    {
        //        A = a;
        //    }
        //    public double Sum(double a, double b)
        //    {
        //        return a + b;
        //    }
        //}
        //class ConsoleOutput
        //{
        //    public void Output(int answer)
        //    {
        //        Console.WriteLine($"Сложение двух чисел = {answer}");
        //    }

        //    //public void Output(double answer)
        //    //{
        //    //    Console.WriteLine($"Сложение двух дробных чисел = {answer}");
        //    //}

        //    //public void Output(string answer)
        //    //{
        //    //    Console.WriteLine($"Вы написали что-то = {answer}");
        //    //}
        //}
        #endregion
    }
}