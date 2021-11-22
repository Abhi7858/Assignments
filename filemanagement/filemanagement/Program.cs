using System;
using System.IO;
namespace filemanagement
{
    class Program
    {
        public static void enterpatient()
        {
            Console.Write("\nEnter Patient's Full Name:- ");
            string patientname = Console.ReadLine();
            Console.Write("Enter Symptoms:- ");
            string symptoms = Console.ReadLine();
            Console.Write("Enter Treatment:- ");
            string treatment = Console.ReadLine();
            Console.Write("Enter Doctor Name:- ");
            string drname = Console.ReadLine();
            string appointmentdate = DateTime.Now.ToString("dd-MM-yyyy");
            string path = @"C:\Users\Public\Documents\wheel\" + patientname + ".txt";
            if (File.Exists(path))
            {
                using (StreamWriter writeinfile = File.AppendText(path))
                {
                    writeinfile.WriteLine(patientname + " " + symptoms + " " + treatment + " " + drname + " " + appointmentdate);
                    Console.WriteLine("Patient's new data is added in existing file Sucessfully..!!\n");
                }

            }
            else
            {
                using (StreamWriter writeinfile = File.CreateText(path))
                {
                    writeinfile.WriteLine(patientname + " " + symptoms + " " + treatment + " " + drname + " " + appointmentdate);
                    Console.WriteLine("Patient's record added Sucessfully..!!\n");
                }
            }
        }
        public static void displaypatient()
        {
            Console.Write("\nEnter Patient's Full Name:- ");
            string patientname = Console.ReadLine();
            string path = @"C:\Users\Public\Documents\wheel\" + patientname + ".txt";
            if (File.Exists(path))
            {
                foreach (string readinfile in File.ReadLines(path))
                {
                    Console.WriteLine(readinfile);
                }
            }
            else
            {
                Console.WriteLine("No Record For {patientname} Patient\n");
            }
        }
        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1.Enter Patient Details: ");
                Console.WriteLine("2. Display Patient Details: ");
                Console.WriteLine("3. Exit ");
                Console.Write("Enter Your Choice:- ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        enterpatient();
                        break;
                    case 2:
                        displaypatient();
                        break;
                    case 0:
                        Console.WriteLine("Thank You..!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 3);
        }
    }
}
