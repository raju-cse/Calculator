public class ScientificCalculator :BasicCalculator,IScientificCalculator
{
    public double SquareRoot(double x)
    {
        if (x < 0)
        {
            throw new ArgumentException("Cannot calculate the square root of a negative number.");
        }
        return Math.Sqrt(x);
    }

    public double Power(double x, double y)
    {
        return Math.Pow(x, y);
    }
}