// ctrl - K - C установить комментарий (два //)
// ctrl - K - U снять комментирование (убрать //)
// Вывести случайное целое число из отрезка [10,99] и показать наибольшую цифру числа

int GenerateRandomNumber()
{
    return new Random().Next(10, 100);
}

int GetMaxDigitForTwoDigitsNumber(int randomNumber)
{
    int firstDigit = randomNumber / 10;
    int secondDigit = randomNumber % 10;

    //2.2 Показать наибольшую цифру

    int max = firstDigit;

    if(secondDigit > firstDigit)
    {
        max = secondDigit;
    }

    return max;

}

//1. Сгенерировать случайное число на отрезке

int randomNumber = GenerateRandomNumber();
Console.WriteLine("Сгенерированное число в диапазоне [10, 99] = " + randomNumber); // Для вывода в консоль сгенерированного числа
    //Console.WriteLine(firstDigit); // Для вывода в консоль первой цифры (нужно только для проверки работы данного элемента кода)
    //Console.WriteLine(secondDigit); // Для вывода в консоль второй цифры (нужно только для проверки работы данного элемента кода)

//2. Найти наибольшую цифру числа

int max = GetMaxDigitForTwoDigitsNumber(randomNumber);

//int firstDigit = randomNumber / 10;
// int secondDigit = randomNumber % 10;

// Console.WriteLine("Сгенерированное число в диапазоне [10, 99] = " + randomNumber); // Для вывода в консоль сгенерированного числа
//Console.WriteLine(firstDigit); // Для вывода в консоль первой цифры (нужно только для проверки работы данного элемента кода)
//Console.WriteLine(secondDigit); // Для вывода в консоль второй цифры (нужно только для проверки работы данного элемента кода)

//3. Показать наибольшую цифру числа

// int max = firstDigit;

// if(secondDigit > firstDigit)
// {
    // max = secondDigit;
// }

Console.WriteLine("Наибольшая цифра сгеренированного числа = " + max);
