using System;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, sum = 0;

            Console.Write("Введите начальное число: ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Введите конечное число: ");
            n = int.Parse(Console.ReadLine());

            for (int i = m; i <= n; i++)  // Цикл для подсчета суммы чисел от M до N 
            {
                sum += i;   // Добавляем текущий элемент в сумму  
            }

            Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {sum}");

        }
    }
}