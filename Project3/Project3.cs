namespace Project3
{
    public delegate double MyDelegate(double a,double b,double c);
    class Project2
    {

        static void Main(string[] args)
        {

            double summand1 = 10, summand2 = 25, sum3 = 20, sum = 0;
            MyDelegate myDeleget = delegate (double a, double b, double c) { return sum = a + b + c; };
            sum = myDeleget(summand1, summand2, sum3);
            double averger = sum / 3;
            Console.WriteLine(averger);


        }

    }
}
//   //я не знаю наскільки я правильно зробив)
//}            MyDelegate myDelegate = delegate (double[] numbers)
//             {
//                 double sum = 0;
//                 foreach (var num in numbers)
//                 {
//                     sum += num;
//                 }
//                 return sum / numbers.Length;
//             };

//double[] values = { 10, 25, 20 };
//double average = myDelegate(values);
//Console.WriteLine($"Середнє арифметичне: {average}");


















