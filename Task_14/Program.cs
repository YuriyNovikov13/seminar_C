// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.Write("введите число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

if (firstNum % 7 == 0 && firstNum % 23 == 0) Console.WriteLine($"{firstNum} -> да");
else Console.WriteLine($"{firstNum} -> нет");


