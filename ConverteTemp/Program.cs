internal class Program
{
    private static void Main(string[] args)
    {
        float temp;

        Console.WriteLine("Digite a temp em ºC: ");
        temp = float.Parse(Console.ReadLine());

        Console.WriteLine("A temperatura em ºF é: " + ((temp -32)*5/9).ToString("F2"));
    }
}