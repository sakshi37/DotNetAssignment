namespace Task1
{
    internal class Program
    {
        private static int opration;

        static void Main(string[] args)
        {
            Queue<int> cust = new Queue<int>();
            int token = 1;
            do
            {
                Console.WriteLine("Which opration do you want to perform\n1.Add customer\n2.Served first customer\n3.who is next\n" +
                    "4.Exit");

                

                int opration = Convert.ToInt32(Console.ReadLine());
                if (opration == 4)
                    return;

                switch (opration)
                {
                    case 1:
                        cust.Enqueue(token);
                        Console.WriteLine($"Customer {token} is added");
                        token ++;
                        break;
                    case 2:
                        if (cust.Count > 0)
                        {
                            int served_cust = cust.Dequeue();
                            Console.WriteLine($" Customer is {served_cust} served ");
                        }
                        else
                            Console.WriteLine("No customer is there");
                        break;
                    case 3:
                        Console.WriteLine($"next custome is: {cust.Peek()} ");
                        break;
                    default:
                        Console.WriteLine("Enter valid input");
                        break;

                }
            } while (opration != 4);
            
        }
}   } 
