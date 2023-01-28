int a = 5;
int b = 9;
int c = 3;
int d = 11;
int e = 25;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine("Максимальное число:");
Console.WriteLine(max);