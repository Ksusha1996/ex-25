// ва числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите число B: ");
        int B = int.Parse(Console.ReadLine());

        int result = Power(A, B);
        Console.WriteLine($"Результат: {result}");
    }

    static int Power(int baseNumber, int exponent)
    {
        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }
}







