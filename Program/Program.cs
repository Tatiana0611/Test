Console.Write("Введите строки через пробел: ");
string? text = Console.ReadLine();
string[] array = text!.Split(' ');

// Поиск количества элементов, длина которых менее 4
int FindElement(string[]array)
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    if (array[i].Length < 4) count++;
    return count;
}

// Формирование нового массива
string[] CopyArray(string[] array, int size)
{
    int j = 0;
    string[] newArray = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) 
        {
            newArray[j] = array[i];
            j++;
        }     
    }
    return newArray;
}

int size = FindElement(array);
string[] newArray = CopyArray(array, size);

Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + ']'); 
Console.WriteLine("Новый массив: [" + string.Join(", ", newArray) + ']');