namespace dz4
{
class Program
{
static void Main(string[] args)
{
    

    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());

    for ( int count = 1; count < number; count++ )
    {
        if (count % 2 == 0){
            Console.WriteLine($"число {count} чётное ");
        }
    }

}
}
}