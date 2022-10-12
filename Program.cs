string [] SelectLessCharacters (string [] arr)
{
    string [] NewArray = new string [arr.Length];
    int step = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 3) {
        NewArray[step] = arr[i];
        step++;
        }
    }

    Array.Resize(ref NewArray, step);
    return NewArray;
}

string[] FillingInArray (int size)
{
    string [] arr = new string [size];
    for (int i = 0; i < size; i++)
    { 
        Console.WriteLine($"Введите {i+1} элемент массива");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray (string[] arr)
{
    Console.WriteLine("[" + string.Join(",",arr) +"]");
}

Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());

string [] stringArray = FillingInArray(size);
PrintArray(stringArray);
Console.WriteLine("");
string [] processedArray = SelectLessCharacters(stringArray);
PrintArray(processedArray);

