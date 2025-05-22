namespace Casting_Implicit_Explicit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Celsius c = new Celsius(123);
            Kelvin k = c;
            Console.WriteLine(k.Degree);
        }
    }
}
