namespace Assighniment_trainbooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selct Type of ticket\n1.Genral-200rs\n2.Ac-1000rs\n3.sleeper-500rs\n4.Exit");
            int genral = 200;
            int ac = 1000;
            int sleeper = 500;

            Console.WriteLine("enter your choices 1,2 ,3 and 4");
            int type = Convert.ToInt32(Console.ReadLine());

           

            switch (type)
            {
                case 1:
                    Console.WriteLine("You selected General. Price: 200 Rs");
                    Console.WriteLine("Select how many you want");
                    int count = Convert.ToInt32(Console.ReadLine());
                    double price = genral * count;
                    Console.WriteLine("Your ticket price is: "+price);

                    break;
                case 2:
                    Console.WriteLine("You selected Ac. Price: 1000 Rs");
                   
                    Console.WriteLine("Select how many you want");
                    int count2 = Convert.ToInt32(Console.ReadLine());
                    double price2 =ac* count2;
                    Console.WriteLine("Your ticket price is: " + price2);

                    break;

                case 3:
                    Console.WriteLine("You selected Sleeper. Price: 500 Rs");
                    
                    Console.WriteLine("Select how many you want");
                    int count3 = Convert.ToInt32(Console.ReadLine());
                    double price3 = sleeper * count3;
                    Console.WriteLine("Your ticket price is: " + price3);

                    break;
                case 4:
                    Console.WriteLine("Thank you");
                    return;
                    break;a


                default: 
                    Console.WriteLine("Please select option given above");
                    break;
            }
        }  
    }
}
