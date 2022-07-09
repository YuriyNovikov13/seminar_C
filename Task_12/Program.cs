// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("определение кратности чисел, является ли второе число кратным первому?   ");
Console.Write("введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введенные числа {firstNum} и {secondNum}");

int division = (firstNum / secondNum);
if (firstNum < secondNum) Console.WriteLine($"Числа {firstNum} , {secondNum} = > не кратно");
else if (firstNum == division * secondNum) Console.WriteLine ($"Числа {firstNum}, {secondNum} -> Кратно");
else Console.WriteLine($"Числа {firstNum} , {secondNum} -> не кратно, остаток: {firstNum - division * secondNum}");
($"Числа {firstNum} , {secondNum} -> Кратно");
// ..решение через терминальную операцию 
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());
string result =firstNum%secondNum==0 ? $"Числа {firstNum} , {secondNum} -> Кратно" : $"{firstNum} % {secondNum} = {firstNum%secondNum}";
Console.WriteLine (result);