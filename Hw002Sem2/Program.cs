int num = new Random().Next(100, 1000);
System.Console.WriteLine($"Случайное трехзначное число - {num}");
int num1 = num / 100;
int num3 = num % 10;
string result = num1.ToString() + num3.ToString();
int res = Convert.ToInt32(result);
System.Console.WriteLine($"Результат = {res}");