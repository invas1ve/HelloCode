System.Console.WriteLine("Введите число...");
string a = Console.ReadLine();
int number = Convert.ToInt32(a);
if (number % 2 == 0)
{
    System.Console.WriteLine("Число четное");
}
else
{
    System.Console.WriteLine("Число нечетное");
}