
using System;

namespace percentage
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {

                Console.WriteLine("Please select which exam student had given?:");
                Console.WriteLine("1.SSC");
                Console.WriteLine("2.NIT");
                Console.WriteLine("3.IIT");
                Console.WriteLine("0.Exit");
                Console.Write("Please enter a choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        IResult ssc = new SSC();
                        ssc.getpercentage();
                        break;
                    case 2:
                        IResult nit = new NIT();
                        nit.getpercentage();
                        break;
                    case 3:
                        IResult iit = new IIT();
                        iit.getpercentage();
                        break;
                    case 0:
                        Console.WriteLine("Thank You");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 0);

        }
    }
}
