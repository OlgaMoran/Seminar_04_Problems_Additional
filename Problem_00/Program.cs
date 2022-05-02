// Найти сумму чисел от 1 до А

int a = new Random().Next(2, 101);
Console.WriteLine(a);
int sum = (a * (1 + a)) / 2;
Console.WriteLine("Sum: " + sum);