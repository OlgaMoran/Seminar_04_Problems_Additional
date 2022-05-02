// 1. Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int a = new Random().Next(2, 11);
Console.WriteLine(a);
int b = new Random().Next(2, 11);
Console.WriteLine(b);
double pow = a;
for (int i = 1; i < b; i++)
{
    pow = pow * a;
}
Console.WriteLine(pow);