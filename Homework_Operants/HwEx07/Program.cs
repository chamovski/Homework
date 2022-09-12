Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int n = 0;
while (n <= 10)
{
    Console.WriteLine($"{num} * {n} = {num * n}");
    n++;
}