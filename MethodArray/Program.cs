int[] array = { 17, 22, 35, 45, 53, 81, 65, 47, 81 };

int n = array.Length;
int find = 81;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}