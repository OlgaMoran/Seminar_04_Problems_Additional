// 2. Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

int SumOfDig(int a)
{
int sum = 0;
for (int div = a; div > 0; div = div / 10) sum = sum + div % 10;
return sum;
}
int n = new Random().Next(1, 10001);
Console.WriteLine(n);
Console.WriteLine(SumOfDig(n));