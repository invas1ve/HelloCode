System.Console.WriteLine("Введите первое число...");
string number1 = Console.ReadLine();
System.Console.WriteLine("Введите второе число...");
string number2 = Console.ReadLine();

int num1 = int.Parse(number1);
int num2 = int.Parse(number2);

if (num1 % num2 == 0)
{
    System.Console.WriteLine("Кратно");
}
else if (num1 % num2 != 0)
{
    System.Console.WriteLine($"Не кратно, остаток {num1 % num2}");
}
else
{
    System.Console.WriteLine("Проверьте что вы ввели числа");
}