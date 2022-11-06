// Задача 63. Задайте вещественнон значение N. Напишите программу, 
// которая выведет все натуральные числа от 1 до N. 
// N = 5 -> "1,2,3,4,5"
// N = 6 -> "1,2,3,4,5,6"

double GetNumberFromConsole()
{
    return Convert.ToDouble(Console.ReadLine());
}

void WriteNumbers(double lastNumber)
{
    int counter = 1;
    while (counter <= lastNumber)
    {
        if (counter + 1 <= lastNumber)
        Console.Write(counter + ", ");
        else 
         Console.Write(counter);
        counter++;
    }
    Console.WriteLine();
}

WriteNumbers(GetNumberFromConsole());
