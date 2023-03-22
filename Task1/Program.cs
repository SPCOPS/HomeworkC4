int step (int a, int b)
{
  int result = 1;
  for (int i = 1; i <= b; i++)
  {
    result = result * a;
  }
return result;
}
Console.Clear();
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int x = step (a, b);
Console.WriteLine($"Ответ: {x}");