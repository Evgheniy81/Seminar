/* Напишите программу которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа.
Н-р: 456 -> 46
///////////
В I-варианте лишнее нахождение 2 цифры, а нам нужны только первая и третья.
int number = new Random().Next(100, 1000);
int firstNum = number / 100;
int secondNum = number % 100 / 10;
int thirdNum = number % 10;
int newNum = firstNum * 10 + thirdNum;
Console.WriteLine($"Our random number is => {number}");
Console.WriteLine($"Our first number is => {firstNum}");
Console.WriteLine($"Our second number is => {secondNum}");
Console.WriteLine($"Our trind number is => {thirdNum}");

Console.WriteLine($"Our new number is => {newNum}");
*/
int number = new Random().Next(100, 1000);
int firstNum = number / 100;
int thirdNum = number % 10;
int newNum = firstNum * 10 + thirdNum;
Console.WriteLine($"Our random number is => {number}");
Console.WriteLine($"Our first number is => {firstNum}");
Console.WriteLine($"Our trind number is => {thirdNum}");

Console.WriteLine($"Our new number is => {newNum}");
