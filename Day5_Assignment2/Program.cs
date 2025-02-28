using Day5_Assignment2.Model;

namespace Day5_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AabClass ab1 = new Wheel_2();
            ab1.calculation();

            AabClass ab2 = new Wheel_4();
            ab2.calculation();

            AabClass ab3 = new Comercial();
            ab3.calculation();
        }
    }
}
