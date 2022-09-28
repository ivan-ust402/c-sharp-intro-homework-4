/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Ограничения:
- Должна быть отдельная функция, которая возвращает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
*/
Console.Clear();
Console.WriteLine("Введите число, чтобы получить сумму цифр, из которых состоит введенное число: ");
int number = int.Parse(Console.ReadLine()!);

int amount = Sum(number);
Console.WriteLine($"Сумма цифр числа: {amount}");

int Sum (int number) {
    int sum = 0;
    while (number != 0) {
        if (number < 0) number = -number;
        int remainder = number % 10;
        number = number / 10;
        sum = sum + remainder;
    }
    return sum;
}