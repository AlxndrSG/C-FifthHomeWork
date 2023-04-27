//Задайте массив заполненный случайными положительными трехзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int length = Prompt("Длина массива: ", "Ошибка! Введены некорректные данные!");
int[] array = GenerateRandomArray(length);
int evenNumber = FindEvenNumber(array);
PrintArrayWithAmountNumber(array);

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
        array[i] = random.Next(100, 1000);
    }
    return array;
}

void PrintArrayWithAmountNumber(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
    Console.WriteLine($" -> {evenNumber}");
}

int FindEvenNumber(int[] arr)
{
    int count=0;
    foreach (int el in arr)
    {
        if (el % 2 == 0)
        count++;
    }
    return count;
}

