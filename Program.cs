// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine ("START");
int value = 276;
int a = value / 100;
int b = (value / 10) % 10;
int c = value % 10;

int result1 = a;
int result2 = b;

Console.Write (result1);
Console.WriteLine (result2);
Console.WriteLine ("end");
