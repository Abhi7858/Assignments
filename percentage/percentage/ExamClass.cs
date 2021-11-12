using System;
using System.Collections.Generic;
using System.Text;

namespace percentage
{
    class SSC : IResult
    {
        public void getpercentage()
        {
            int percentage,sum=0;
            int[] subjects = new int[5];
            Console.WriteLine("Enter subject marks:");
            for (int i = 0; i < subjects.Length; i++)
            {
                subjects[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < subjects.Length; i++)
            {
                sum = sum + subjects[i];
            }
                percentage = sum / 5;
                Console.WriteLine("percentage of student is: {0}%", percentage);
        }
    }

    class NIT : IResult
    {
        public void getpercentage()
        {
            double cgpa, percentage;
            Console.Write("Please Enter cgpa outof 10:");
            cgpa = Convert.ToDouble(Console.ReadLine());
            percentage = cgpa * 9.5;
            Console.WriteLine("percentage of student is: {0}%", percentage);
        }
    }

    class IIT : IResult
    {
        public void getpercentage()
        {
            double cgpa, percentage;
            Console.Write("Please Enter cgpa outof 10:");
            cgpa = Convert.ToDouble(Console.ReadLine());
            percentage = cgpa * 10;
            Console.WriteLine("percentage of student is: {0}%", percentage);
        }
    }
}
