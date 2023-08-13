Console.Clear();


// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int EnterArray(string massage)
{
System.Console.WriteLine(massage);
int numbers = Convert.ToInt32(Console.ReadLine());
return numbers;
}

int [] ImputArray(int lenght)
{
    int [] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = EnterArray($"Enter {i+1} - th element");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int lenght = EnterArray("How many numbers'll you enter?");
int [] array;
array = ImputArray(lenght);
PrintArray(array);
Console.WriteLine($"The number of numbers greater then zero is equal: {Count(array)}");