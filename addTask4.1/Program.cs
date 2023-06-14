// 4.1. Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет,
//  кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.

// Пример: Введенное число 2
// 13 -> нет 
// 15 -> нет 
// 12 -> да

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write(message);                      // Вывод приглашения
    int number = Convert.ToInt32(Console.ReadLine());   // Чтение строки и преобразование в число
    return number;                                      // Возврат целого числа
}
int digit2 = ReadInt("Введите число: ");

while (digit2 != 0)
{
int Ran()
{
    int x11 = new Random().Next(10, 1000);
    //System.Console.WriteLine($"случайное число: {x11}");
    return x11;
}
int digit1 = Ran();

int Rem(int digit1, int digit2)
{
    int rem = digit1 % digit2;
    if (rem == 0)
    {
        return rem;
    }
    rem = digit2 % digit1;
    return rem;
}

int rem = Rem(digit1, digit2);
   
    if (rem == 0)
    {
        System.Console.WriteLine($"Число: {digit1} кратно введеному числу: {digit2}");
        break;
    }
    if (rem != 0)
    {
        System.Console.WriteLine($"Число: {digit1} не кратно числу: {digit2}");  
    }
}

