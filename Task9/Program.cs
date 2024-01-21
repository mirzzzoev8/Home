int number = Convert.ToInt32(Console.ReadLine());

int power = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowerOfNumber(number, power) );
    

int PowerOfNumber(int number, int power)
{
    if (power == 0)
    {
        return 1; 
    }
    else
    {
        return number * PowerOfNumber(number, power - 1);
    }
}


    