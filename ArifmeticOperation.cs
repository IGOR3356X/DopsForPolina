namespace CharpDops
{
    public class ArifmeticOperation
    {
        static Random Random = new Random();
        

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int MinusRandom(int a)
        {
            int ran = Random.Next(1, 10);
            Console.WriteLine($"Рандомное число = {ran}");
            return a - ran;
        }

        public int MultyRandom(int a)
        {
            int ran = Random.Next(1, 10);
            Console.WriteLine($"Рандомное число = {ran}");
            return a * ran;
        }
    }
}