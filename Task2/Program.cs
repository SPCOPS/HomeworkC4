int sumnumb (int a)
{
  int result = 0;
  while (a > 0)
  {
    result += a % 10;
    a = a / 10;
  }
return result;
}
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int x = sumnumb (a);
Console.WriteLine($"Ответ: {x}");