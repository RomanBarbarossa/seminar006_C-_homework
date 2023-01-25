
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
// Для строки можно использовать данный метод: string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
// (пользователь вводит в консоли числа через пробел и они формируют строку)


// System.Console.WriteLine("Введите числа через пробел: ");
// int[] numsInt = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// System.Console.WriteLine($"[{String.Join("|",numsInt)}]");

// int sum = 0;

// for (int i = 0; i < numsInt.Length; i++)
// {
//     if(numsInt[i] > 0)
//     {
//         sum += numsInt[i];
//     }
// }
// Console.WriteLine($"Сумма чисел > 0 равна: {sum} ");



// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов 
// (не менее 6) в промежутке от 0 до 100, а на выходе выводит этот же массив, 
// но отсортированный по возрастанию(от меньшего числа к большему).

// ------Методы------------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void SortArray(int[] array)
{
    bool sorted = true;
    while (sorted == true)
    {
        sorted = false;
        for(int i = 0; i < array.Length-1; i++)
    {
        if(array[i] > array[i + 1])
        {
            int temp = array[i];
            array[i] = array[i+1];
            array[i+1] = temp;
            sorted = true;
        }
    }
    }
    
        Console.WriteLine($"Отсортированный массив:[{String.Join("|", array)}]");

}

int[] collection = GetArray (10,0,100);
Console.WriteLine($"Изначальный массив:[{String.Join("|", collection)}]");
SortArray(collection);