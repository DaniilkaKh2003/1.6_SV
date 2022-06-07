using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                while (n % i == 0)
                {
                    sum += i;
                    break;
                }
            }
            Console.WriteLine($"Сумма делителей = {sum}");
        }
    }
}
