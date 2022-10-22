int GenerateRandomNumber()
{
    return new Random().Next(100, 1000);
}

int randomNumber = GenerateRandomNumber();
Console.WriteLine("Сгенерированное число = " + randomNumber);

int firstNum = randomNumber / 100;
//int secondNum = randomNumber / 10 % 10;
int thirdNum = randomNumber % 100 % 10;

//Console.WriteLine("первая цифра = " + firstNum);
//Console.WriteLine("вторая цифра = " + secondNum);
//Console.WriteLine("третья цифра = " + thirdNum);

Console.WriteLine("Число без второй цифры = " + firstNum + thirdNum);