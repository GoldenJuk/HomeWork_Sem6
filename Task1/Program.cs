//Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

using System.Security;

Console.Clear();

int[] GetUserNumbers(int[] numbers)
{ 
    string stop = string.Empty;
    int i = 0;
    while (stop != "stop")
    {
        stop =  Convert.ToString(Console.ReadLine());
        if (stop != "stop")
        {
            numbers[i] = Convert.ToInt32(stop);
            i++;
        }
    }
    return numbers;
}

int GetNumberOfPositiv(int[] array)
{
    int count = 0;  
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите числа");
Console.WriteLine("Когда захотите остановиться, наберите - stop ");

int[] numUser = new int[25];
GetUserNumbers(numUser);
Console.WriteLine();

int numberOfPositiv = GetNumberOfPositiv(numUser);

Console.WriteLine($"Из введенных чисел, количество больше 0 составляет: {numberOfPositiv}");
Console.WriteLine();