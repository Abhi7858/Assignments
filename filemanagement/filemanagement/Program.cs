using System;
using System.IO;
namespace filemanagement
{
    class Program
    {
        public static void EnterPatientDetails()
        {
            Console.Write("\nEnter Patient's Full Name:- ");
            string patientName = Console.ReadLine();
            Console.Write("Enter Symptoms:- ");
            string symptoms = Console.ReadLine();
            Console.Write("Enter Treatment:- ");
            string treatment = Console.ReadLine();
            Console.Write("Enter Doctor Name:- ");
            string drName = Console.ReadLine();
            string appointmentDate = DateTime.Now.ToString("dd-MM-yyyy");
            string path = @"C:\Users\Public\Documents\wheel\" + patientName + ".txt";
            if (File.Exists(path))
            {
                using (StreamWriter writeinFile = File.AppendText(path))
                {
                    writeinFile.WriteLine(patientName + " " + symptoms + " " + treatment + " " + drName + " " + appointmentDate);
                    Console.WriteLine("Patient's new data is added in existing file Sucessfully..!!\n");
                }

            }
            else
            {
                using (StreamWriter writeinFile = File.CreateText(path))
                {
                    writeinFile.WriteLine(patientName + " " + symptoms + " " + treatment + " " + drName + " " + appointmentDate);
                    Console.WriteLine("Patient's record added Sucessfully..!!\n");
                }
            }
        }
        public static void DisplayPatientDetails()
        {
            Console.Write("\nEnter Patient's Full Name:- ");
            string patientName = Console.ReadLine();
            string path = @"C:\Users\Public\Documents\wheel\" + patientName + ".txt";
            if (File.Exists(path))
            {
                foreach (string readinFile in File.ReadLines(path))
                {
                    Console.WriteLine(readinFile);
                }
            }
            else
            {
                Console.WriteLine("No Record For {patientName} Patient\n");
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
                        EnterPatientDetails();
                        break;
                    case 2:
                        DisplayPatientDetails();
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
