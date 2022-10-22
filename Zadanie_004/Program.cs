Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);

if(Square(num1, num2))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

bool Square(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}

