// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");
int firstDigit = rndNum / 10;
int secondDigit = rndNum % 10;
// решение 1
if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра из {rndNum} => {firstDigit}");
else if (firstDigit < secondDigit) Console.WriteLine($"Наибольшая цифра из {rndNum} => {secondDigit}");
else Console.WriteLine($"Цифры числа {rndNum} равны");
// решение через максимальное значение
int maxDigit = firstDigit;
if (secondDigit > maxDigit) maxDigit = secondDigit;
else if (secondDigit == maxDigit) maxDigit = 0;

if (maxDigit > 0) Console.WriteLine($"Наибольшая цифра из {rndNum} => {maxDigit}");
else Console.WriteLine($"Цифры числа {rndNum} равны");

//            (         если         )тогда      иначе
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра из {rndNum} => {maxDigit}");

// решение с помощью метода (функции)
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxDigit = MaxDigit(rndNum);
//                             перевели из int в string
string result = maxDigit > 0 ? maxDigit.ToString() : "числа равны";
Console.WriteLine($"Наибольшая цифра из {rndNum} => {result}");
