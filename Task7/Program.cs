int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if (x > y)
{
    return;
}

for (int i = x; i <= y; i++)
{
    for (int j = 1; j <= 10; j++)
        {
            int s = i * j;
            Console.WriteLine(i + " * " + j + " = " + s);
        }
}