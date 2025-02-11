using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpDops
{
    internal class ConsoleOutput
    {
        int A;
        int B;
        public ConsoleOutput(int a, int b)
        {
            A = a; 
            B = b;
        }

        ArifmeticOperation operation = new ArifmeticOperation();

        public void WriteAll()
        {
            int answer = operation.Sum(A, B);
            OutputSum(answer);

            answer = operation.MinusRandom(answer);
            OutputMinus(answer);

            answer = operation.MultyRandom(answer);
            OutputMulty(answer);
        }

        public void OutputSum(int answer)
        {
            Console.WriteLine($"Сложение двух чисел = {answer}");
        }

        public void OutputMinus(int answer)
        {
            Console.WriteLine($"Минус рандомное число = {answer}");
        }

        public void OutputMulty(int answer)
        {
            Console.WriteLine($"Умножить на рандомное число = {answer}");
        }
    }
}
