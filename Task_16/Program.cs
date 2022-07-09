// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.WriteLine("Является ли одно число, квадратом другого");
Console.Write("введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
if (firstNum % secondNum == 0) Console.WriteLine($"{firstNum}, {secondNum} -> ДА");
else if (secondNum % firstNum == 0) Console.WriteLine($"{firstNum}, {secondNum} -> ДА");
else Console.WriteLine($"{firstNum}, {secondNum} -> НЕТ");
