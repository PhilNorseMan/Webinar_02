void GetDivisionMultiplicity(int num1, int num2)
{
    int result = num1 % num2;

    if(result == 0)
    {
        Console.WriteLine("Числа являются кратными");
    }
    else
    {
        Console.WriteLine("Числа не являются кратными. Остаток = " + result);
    }

}

Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine()!);

GetDivisionMultiplicity(num1, num2);