int monday = 1, tuesday = 2, 
    wednesday = 3, thursday = 4, friday = 5, saturday = 6, sunday = 7;
Console.WriteLine("Type your number");
string console = Console.ReadLine();
int con = int.Parse(console);
if(con == monday)
{
 Console.WriteLine("It's monday");
}
else if(con == tuesday)
{
 Console.WriteLine("It's tuesday");
}
else if(con == wednesday)
{
 Console.WriteLine("It's wednesday");
}
else if(con == thursday)
{
 Console.WriteLine("It's thursday");
}
else if(con == friday)
{
 Console.WriteLine("It's friday");
}
else if(con == saturday)
{
 Console.WriteLine("It's saturday");
}
else if(con == sunday)
{
 Console.WriteLine("It's sunday");
}
else
{
 Console.WriteLine("There is no such thing! :)");
}

