Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

if(Mult(num))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

bool Mult(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}