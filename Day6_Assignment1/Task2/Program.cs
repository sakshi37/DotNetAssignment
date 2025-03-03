using System.Collections;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable student = new Hashtable();

            Console.WriteLine("Enrolled for the cours which you want to\n How many courses do you wnat to enrolled");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=num;i++)
            {
                Console.WriteLine("enter key for your course");
                int key =Convert.ToInt32( Console.ReadLine());

                Console.WriteLine("Enter the name of your Course");
                String course = Console.ReadLine();

                if (student.Contains(key))
                {
                    Console.WriteLine("Key alredy exist");
                    i--;
                }
                else
                {
                    student.Add(key, course);
                }
            }

        }
    }
}
