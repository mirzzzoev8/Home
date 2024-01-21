double num1 = Convert.ToDouble(Console.ReadLine());
char znak = Convert.ToChar(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
double cnt = 0;
switch (znak)
        {
            case '+':
                cnt = num1 + num2;
                break;
            case '-':
                cnt = num1 - num2;
                break;
            case '*':
                cnt = num1 * num2;
                break;
            case '/':
                cnt = num1 / num2;
                break;
            default:
                return;
        }

        Console.WriteLine( cnt);