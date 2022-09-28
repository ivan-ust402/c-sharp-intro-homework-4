/* 
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
Ограничения:
- Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
- Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода
*/
Console.Clear();
Console.WriteLine("Вы находитесь в программе, которая задаёт массив из 8 рандомных элементов и выводит их на экран. Для продолжения нажмите Enter...");
Console.ReadLine();

int[] array = CreateArray();
PrintArray(array);


int[] CreateArray() {
    int[] arr = new int[8];
    Random elementGen = new Random();
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = elementGen.Next();
    }
    return arr;
}

void PrintArray(int[] arr) {
    for (int i = 0; i < array.Length; i++) {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1) 
            Console.Write($"{array[i]}]");
        else 
            Console.Write($"{array[i]}, ");        
    }
}