// 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] Array)
{   
    int length = Array.Length;
    for (int index = 0; index < length; index++)
    {
        Array[index] = new Random().Next(1, 101);
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.WriteLine(array[pos]);
    }
}

int[] myArray = new int[8];
FillArray(myArray);
PrintArray(myArray);