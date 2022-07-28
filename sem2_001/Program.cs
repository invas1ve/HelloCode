int number = new Random().Next(10,100);
System.Console.WriteLine($"Случайное число: {number}");
int number1 = number / 10;
int number2 = number % 10;

if (number1 > number2)
{
    System.Console.WriteLine($"Наибольшая цифра: {number1} ");
}
else if (number2 > number1)
{
    System.Console.WriteLine($"Наибольшая цифра: {number2}");
}
else System.Console.WriteLine("Обе цифры одинаковы");