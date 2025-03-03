using System.Collections;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable student = new Hashtable();

            Console.WriteLine("Enrolled for the Workshop which you want to\n How many Workshop do you want to enrolled");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=num;i++)
            {
                Console.WriteLine("enter Student id for workshop");
                int key =Convert.ToInt32( Console.ReadLine());

                if (student.Contains(key))
                {
                    Console.WriteLine("Key alredy exist");
                    i--;
                }
                else
                {
                    Console.WriteLine("Enter the name of your workshop");
                    String course = Console.ReadLine();

                    student.Add(key, course);
                }

                

            }

        }
    }
}
