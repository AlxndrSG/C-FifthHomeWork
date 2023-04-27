// Задайте массив вещественных чисел. Найдите разницу
//между максимальным и минимальным элементов массива.

Console.Clear();

int length = Prompt("Длина массива: ", "Ошибка! Введены некорректные данные!");
double[] array = GenerateRandomArray(length);
double findDiff = FindMaxMin(array);
PrintArrayWithDiff(array);

int Prompt(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}

double[] GenerateRandomArray(int Length)
{
    double[] array = new double[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100);
    }
    return array;
}

void PrintArrayWithDiff(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
    Console.WriteLine($" -> {findDiff}");
}

double FindMaxMin(double[] arr)
{
    double maxNumber = arr[0];
    double minNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber)
        {
            maxNumber = arr[i];
        }
        if (arr[i] < minNumber)
        {
            minNumber = arr[i];
        }
    }
    return maxNumber - minNumber;
}
