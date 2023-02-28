// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int index = 1;
while (index <= n)
{
   if (index % 2 == 0)
        if (index == n || index == n - 1)
        Console.WriteLine(index);
        else
        Console.Write(index + ", ");
    index = index + 1;
}
    Console.WriteLine();




   
    

    

  


