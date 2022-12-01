Console.Write("Введите общее число печенек N:  ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение печенек для взятия игроком: ");
int m = int.Parse(Console.ReadLine());

int y; //остаток после взятия
int x; // первое взятие игроком 1
int k; // взятие игроком 2
int count; // счетчик шагов


x = N % (m+1);
Console.Write("Первый игрок взял: " + x);
Console.WriteLine(" ");
y = N - x;
Console.Write("Осталось после взятия первым игроком: " + y);
Console.WriteLine(" ");

while (y >0)
{
    k = new Random().Next(1, m); // рандомизируем взятие игроком 2
    Console.Write("Второй игрок взял: " + k);
    Console.WriteLine(" ");
    y = y - k; // остаток от взятия игроком 2
    Console.Write("Осталось после взятия вторым игроком: " + y);
    Console.WriteLine(" ");
        if (y == 0)
    {
        Console.Write("Победил игрок 2");
        Console.WriteLine(" ");
    }
    x = (m + 1) - k; // расчет взятия игроком 1
    Console.Write("Первый игрок взял: " + x);
    Console.WriteLine(" ");
    y = y - x; // остаток после взятия игроком 1
    Console.Write("Осталось после взятия первым игроком: " + y);
    Console.WriteLine(" ");
    if (y == 0)
    {
        Console.Write("Победил игрок 1");
        Console.WriteLine(" ");
    }

}
