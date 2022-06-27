namespace dz3
{
class Program
{
static void Main(string[] args)
{
    
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0){
        Console.WriteLine($"число {number} чётное ");
    }
    else {
        Console.WriteLine($"число {number} нечётное ");
    }
    
}
}
}