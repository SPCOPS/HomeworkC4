int[] massiv(int Length, int min, int max)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(min, max + 1); 
    }
    return array;
}
void printArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write($"{array[array.Length - 1]}");
Console.WriteLine("]");
}
Console.Clear();
int length = 8;
int min = 10;
int max = 50;
int [] array = massiv(length, min, max);
Console.Write("Получен массив: ");
printArray(array);