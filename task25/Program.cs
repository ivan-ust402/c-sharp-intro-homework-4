/*  
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвразает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
*/
Console.Clear();
Console.WriteLine("Введите число, возводимое в степень.");
Console.Write("A: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число, являющееся степенью");
Console.Write("B: ");
int b = int.Parse(Console.ReadLine()!);

int result = Power(a, b);
if (result == -1)
{
    Console.WriteLine($"Степень должна быть натуральным числом, т. е. положительным и не нулем. Учитывая данное условие, попробуте выполнить программу снова...");
}
else
{
    Console.WriteLine($"Результат вычислений: {result}");
}


int Power(int number, int n)
{
    // if (n < 0)
    // {
    //     return -1;
    // }
    // else if (n == 0)
    // {
    //     return 1;
    // }
    if (n <= 0) 
    {
        return -1;
    }
    else
    {
        int pow = 1;
        for (int i = 1; i <= n; i++)
        {
            pow = pow * number;
        }
        return pow;
    }
}