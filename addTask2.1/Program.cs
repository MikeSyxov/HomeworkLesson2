//Напишите программу, которая выводит случайное число из отрезка [10, 9999]
// и показывает наибольшую цифру числа.
//  7812 -> 8 
//  1213-> 3 
//  845 -> 8

int rand = new Random().Next(10, 9999);

int Max(int rand)
{
    int i = 0;
    while(rand > 0)
    {
        int rem10 = rand % 10; 
        if (rem10 > i)
        {
            i = rem10;
        }
        rand /= 10; 
    }
    return i;
}

System.Console.WriteLine($"Число: {rand}. Максимальная цифра: {Max(rand)}");