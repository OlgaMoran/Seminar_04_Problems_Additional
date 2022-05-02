// 2. Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

int a = new Random().Next(1, 10001);
System.Console.WriteLine();
int sum = 0;
for (int div = a; div > 0; div = div / 10)
{
    sum = sum + div % 10;
}
System.Console.WriteLine(sum);