string str = Console.ReadLine();
int number = int.Parse(str);
int num1Check = 7;
int num2Check = 23;

if ((number % num1Check) == 0 && (number % num2Check == 0))
{
    System.Console.WriteLine("Число кратно 7 и 23");
}
else
{
    System.Console.WriteLine("Число не кратно 7 и 23");
}