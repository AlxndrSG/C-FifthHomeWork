//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int length = Prompt("Длина массива: ", "Ошибка! Введены некорректные данные!");
int[] array = GenerateRandomArray(length);
int sumNumber = FindSum(array);
PrintArrayWithSumNumber(array);

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

int[] GenerateRandomArray(int Length)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(-99, 100);
    }
    return array;
}

void PrintArrayWithSumNumber(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
    Console.WriteLine($" -> {sumNumber}");
}

int FindSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        sum += arr[i];
    }
    return sum;
}

