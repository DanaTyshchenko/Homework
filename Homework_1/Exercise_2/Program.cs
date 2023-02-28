// Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число:");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int number_3 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
   
    if (number_1 > number_3)
    Console.WriteLine(number_1);
    else 
    Console.WriteLine(number_3);
   
if (number_2 > number_3)
Console.WriteLine(number_2);

else 
    Console.WriteLine(number_3);


    
    
    