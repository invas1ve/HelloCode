Console.WriteLine("Enter number...");
string number = Console.ReadLine();
int n = int.Parse(number);
for (int i = -n; i <= n; i++)
{ 
  if(i == n)
  {
    Console.Write(i);
  }
  else
  {
    Console.Write(i + ", ");
  }
}