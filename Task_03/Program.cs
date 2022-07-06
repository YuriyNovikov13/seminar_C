// Напишите программу, которая будет выдавать название недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Определение дня недели по его порядковому номеру.");
Console.Write("введите порядковый номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    Console.Write("День недели: Понедельник");
}
else if (a == 2)
{
    Console.Write("День недели: Вторник");
}
else if (a == 3)
{
    Console.Write("День недели: Среда");
}
else if (a == 4)
{
    Console.Write("День недели: Четверг");
}
else if (a == 5)
{
    Console.Write("День недели: Пятница");
}
else if (a == 6)
{
    Console.Write("День недели: Суббота");
}
else if (a == 7)
{
    Console.Write("День недели: Воскресенье");
}
else
{
    Console.Write("введено не корректное число");
}