using Microsoft.VisualBasic;
using System.Dynamic;

namespace Project2
{
    public delegate int MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate[] ran = new MyDelegate[]
            {
             ()=>new Random().Next(1,100),
             ()=>new Random().Next(1,100),
             ()=>new Random().Next(1,100),
             ()=> new Random().Next(1,100)
            };
            double sum = GetDelegat(ran);
            Console.WriteLine(sum);
        }

        public static double GetDelegat(MyDelegate[] ran)
        {
            double sum = 0;
            foreach (var res in ran)
            {
                sum += res();
            }
            return sum / ran.Length;
        }
    }
}