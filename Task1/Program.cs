int n = Convert.ToInt32(Console.ReadLine());
int EvenCount(int n)
{
    int cnt = 0;
    for (int i = n; i > 0; i/=10)
    {
         if((i%10) % 2 == 0) cnt++;
    }
    return cnt;

}

int OddCount(int n)
{
    int cnt = 0;
    for (int i = n; i > 0; i/=10)
    {
          if((i%10) % 2 != 0) cnt++;
    }
    return cnt;

}
int ZeroCount(int n)
{
    int cnt = 0;
    for (int i = n; i > 0; i/=10)
    {
        if (i == 0)
        {
             cnt++;
        }
       
    }
    return cnt;
    
}

int DigitCount(int n)
{
    int cnt = 0;
    for (int i = n; i > 0; i/=10)
    {
        cnt++;
    }
    return cnt;
    
}
int MinDigit(int n)
{
    int cnt = 0;
    for (int i = n; i > 0; i/=10)
    {
        if (i < 0 )
        {
            cnt++;
        }
       
    }
    return cnt;
    
}
int MaxDigit(int n)
{
    int cnt = 0;
    for (int i = n; i > 0; i/=10)
    {
        if (i > 0 )
        {
            cnt++;
        }
       
    }
    return cnt;
    
}
int SumCount(int n)
{
    int cnt = 0;    
    for (int i = n; i > 0; i/=10)
    {
        cnt+=i%10;
    }
    return cnt;
    
}
System.Console.Write("Even : ");
System.Console.WriteLine(EvenCount(n));

System.Console.Write("Odd : ");
System.Console.WriteLine(OddCount(n));

System.Console.Write("Zeros : ");
System.Console.WriteLine(ZeroCount(n));

System.Console.Write("Digits : ");
System.Console.WriteLine(DigitCount(n));

System.Console.Write("Min : ");
System.Console.WriteLine(MinDigit(n));

System.Console.Write("Max : ");
System.Console.WriteLine(MaxDigit(n));

System.Console.Write("Sum of Digits : ");
System.Console.WriteLine(SumCount(n));



