System.Console.WriteLine("Введите число... ");
int n = int.Parse(Console.ReadLine());
if (n > 99)
{
   string number = n.ToString();
   System.Console.WriteLine($"Третья цифра - {number[2]}");
}
else
{
    System.Console.WriteLine($"Число - {n}, третьей цифры нет");
}
