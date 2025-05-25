namespace Casting_Implicit_Explicit.Models
{
    public class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.Degree + 273);
        }
    }

}
