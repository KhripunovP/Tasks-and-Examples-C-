// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Четные числа в диапазоне от 1 до N:");
if (n > 0)
{
while (i <= n)
{
if (i % 2 == 0)
Console.WriteLine ($"{i}");
i++;
}}
else
{
while (i >= n)
{
if (i % 2 == 0)
Console.WriteLine ($"{i}");
i--;
}}