System.Console.WriteLine("Введите цифру...");
int n = int.Parse(Console.ReadLine());
if (n >= 1 && n <= 7)
{
    if (n >= 1 && n <= 5)
    {
        System.Console.WriteLine("Будний день");
    }
    else if (n == 6 || n == 7)
    {
        System.Console.WriteLine("Выходной");
    }
}
else 
{
    System.Console.WriteLine("Введите цифру обозначающую день недели от 1 до 7");
}

