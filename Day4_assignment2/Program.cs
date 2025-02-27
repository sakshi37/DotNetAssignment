using inheritance_demo.Model;

namespace inheritance_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee
            //{
            //    Name = "Alice",
            //    Salary = 50000
            //};
            //emp.Display();



            Manager mgr = new Manager("Bob", 80000, 20000);
            

            Console.WriteLine("Manager Details:");
            mgr.Display(); 


           
        }
    }
}
