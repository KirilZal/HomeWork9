using System.Reflection.Metadata.Ecma335;

namespace Project1
{
    public delegate double Operation(double x, double y);

    public class Calculator
    {
        public static double Add(double x, double y) => x + y;
        public static double Subtract(double x, double y) => x - y;
        public static double Multiply(double x, double y) => x * y;
        public static double Divide(double x, double y) => y != 0 ? x / y : double.NaN;
    }





}