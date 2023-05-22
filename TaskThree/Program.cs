// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("What day of the week are you interested in?");
    int dayWeek = Convert.ToInt32(Console.ReadLine());
        if(dayWeek == 6 || dayWeek == 7){
            Console.WriteLine("Weekend.");
        } else if(dayWeek >= 1 && dayWeek <= 5){
            Console.WriteLine("Weekday.");
        } else{
            Console.WriteLine("There is no such day in the week.");
        }