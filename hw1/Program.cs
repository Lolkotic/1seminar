/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число");
int Number = Convert.ToInt32(Console.ReadLine());

int FirstResult = Number / 10;

int result = FirstResult % 10;
Console.WriteLine($"Вторая цифра данного трехзначного числа это {result}");
