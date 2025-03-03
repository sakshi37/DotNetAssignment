using Task3.Model;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "sakshi",DateTime.Parse("1/1/2000"));
            emp1.Calculate();
            
        }
    }
}
