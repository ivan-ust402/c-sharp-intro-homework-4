/* 
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
Ограничения:
- Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
- Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода
*/

void CreateArray() {
    int[] arr = new int[8];
    Random elementGen = new Random();
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = elementGen.Next();
    }
}

void PrintArray(int[] arr) {
    for (int i = 0; i < array.Length; i++) {
        if 
            (i == 0) Console.WriteLine($"[ {array[i]}, ");
        else if (i == array.Length - 1) 
            Console.WriteLine($"{array[i]} ]");
        else 
            Console.WriteLine($"{array[i]}, ");        
    }
}