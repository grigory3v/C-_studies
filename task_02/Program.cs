namespace dz2
{
class Program
{
static void Main(string[] args)
{
    
    Console.WriteLine("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите третье число");
    int number3 = Convert.ToInt32(Console.ReadLine());

    if ( number2 > number1 ){
        number1 = number2;
    }   

    if (number3 > number1){
        number1 = number3;
    }  

    Console.WriteLine($"Число {number1} является болшьшим");
}
}
}