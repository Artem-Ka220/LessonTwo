//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console. WriteLine("Enter some number: ");
int youNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Third digit of your number: {thirdNumber(youNumber)}.");

int thirdNumber(int num){
    if(num >= 100 && num <= 999){
        num = num % 10;
    }
     else {
        while(true){
            num = num / 10;
            if(num <= 100 || num <= 999){
                num = num % 10;
                break;
            }
        }
    }
    return num;
}


