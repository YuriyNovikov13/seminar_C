// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {rndNum}");
int firstDigit = rndNum / 100;
int secondDigit = rndNum % 10;

// // Console.WriteLine($"число с удаленной второй цифрой {firstDigit}{secondDigit}");
int num = (firstDigit * 10 + secondDigit);
Console.WriteLine($"число с удаленной второй цифрой {num}");

// простое решение:
int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {rndNum}");
int newNum = rndNum / 100 * 10 + rndNum % 10;
Console.WriteLine($"число с удаленной второй цифрой {newNum}");

// решение через метод
int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {rndNum}");
int NewNum(int num)
{
    int firstDigit = rndNum / 100;
    int secondDigit = rndNum % 10;
    return firstDigit * 10 + secondDigit;
}
int result = NewNum(rndNum);
Console.WriteLine($"число с удаленной второй цифрой {nresult}");