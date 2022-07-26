Console.WriteLine("Enter your number...");
string number = Console.ReadLine();
if (number.Length == 3)
{
    if (number == "000")
    {
        Console.WriteLine("Not a number");
    }
    else
    {
        int n = int.Parse(number);
        int lastDigit = n % 10;
        Console.WriteLine("The last digit is: " + lastDigit);
    }

}
else
{
    Console.WriteLine("Please enter three-digit number and try again");
}