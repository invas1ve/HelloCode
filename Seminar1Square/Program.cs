Console.WriteLine("Enter first number: ");
string number1 = Console.ReadLine();
Console.WriteLine("Enter second number: ");
string number2 = Console.ReadLine();
int num1 = int.Parse(number1);
int num2 = int.Parse(number2);
int squareNum1 = num1 * num1;
if(num2 == squareNum1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
