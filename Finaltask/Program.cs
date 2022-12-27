// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам

Console.Write("Введите длину массива: ");

int initArrayLength = Convert.ToInt32(Console.ReadLine());

while (initArrayLength < 1)
{
    Console.WriteLine("Введено неверное значение, длина массива должна быть больше 0. Введите длину массива: ");
    initArrayLength = Convert.ToInt32(Console.ReadLine());
}

string[] FillArray(int arrayLength)
{
    string[] initArray = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        initArray[i] = Console.ReadLine();
    }
    return initArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\u0022{array[i]}\u0022, ");
    }
    if (array.Length > 0) 
    {
        Console.Write($"\u0022{array[array.Length - 1]}\u0022");
    }
    Console.WriteLine("]");
}

string[] array = FillArray(initArrayLength);
PrintArray(array);

string[] CreateArray(string[] array)
{
    int newArrayLength = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) newArrayLength++;
    }

    string[] newArray = new string[newArrayLength];
    int count = 0;

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            newArray[count] = array[j];
            count++;
        }
    }
    return newArray;
}

PrintArray(CreateArray(array));