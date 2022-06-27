namespace dz1
{
class Program
{
static void Main(string[] args)
{
    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    
    if (number1 == number2){
        Console.WriteLine($"{number1} равно {number2}");
    }
    else
        if (number1 >  number2){
        Console.WriteLine($"Число {number1} является болшьшим, число {number2} является меньшим");
    }
        else {
        Console.WriteLine($"Число {number2} является болшьшим, число {number1} является меньшим");
    }      
    }
    }
}
