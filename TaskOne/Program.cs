//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Enter some number: ");
int yourNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Second digit your number: {secondNumber(yourNumber)}.");

int secondNumber(int num){
    int firstNumber = num / 100 * 100;
    int lastNumber = num % 10;
    int secondNumber = (num - firstNumber - lastNumber) / 10;
    return secondNumber;
}