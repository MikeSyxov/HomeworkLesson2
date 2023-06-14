// addTask3.1. Напишите программу, которая будет принимать на вход пять чисел 
// и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 

int ReadInt(string message)
{
    Console.Write(message);                                          // Вывод приглашения
    int number = System.Convert.ToInt32(Console.ReadLine());           // Чтение строки и преобразование в число
    return number;                                                     // Возврат целого числа
}

int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

int[] arr = new int[5];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = ReadInt($"Введите {i + 1} число: ");
}

Console.WriteLine($"Сумма чисел равна {Sum(arr)},среднее значение чисел: {(double)Sum(arr) / arr.Length}");
