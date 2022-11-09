int m = 3;
int size = 5;
string[] arrayOne = new string[size];
Console.WriteLine($"Введите набор символов {size} раз без пробелов");
FillArray(arrayOne);
Console.Clear();
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine($"Новый массив, содержащий элементы, размер которых меньше либо равен {m}:");
if (FindLengthOfSecondArray(arrayOne) == 0)
{
    Console.WriteLine("Искомых элементов для переноса в новый массив - нет");
}
else 
{
    string[] arrayTwo = TransferringArrayElements(arrayOne);
    PrintArray(arrayTwo);
}
void FillArray(string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}

void PrintArray(string[] arr)
{
    int arrLeng = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < arrLeng; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

int FindLengthOfSecondArray(string[] arr)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= m)
        secondSize++;
    }
    return secondSize;
}

string[] TransferringArrayElements(string[] arr)
{
    string[] arrayTwo = new string[FindLengthOfSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if (arr[i].Length <= m)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
        
    }
    return arrayTwo;
}