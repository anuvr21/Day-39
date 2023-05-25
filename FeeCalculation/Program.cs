using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student type:");
            string studentType = Console.ReadLine();
            Console.WriteLine("Enter tuition fee:");
            float tuition = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter bus fee:");
            float bus = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter hostel fee:");
            float hostel = float.Parse(Console.ReadLine());

            float totalFee = 0.0f;

            if (studentType == "MSDS")
            {
                totalFee = tuition + bus;
            }
            else if (studentType == "MSH")
            {
                totalFee = tuition + hostel;
            }
            else if (studentType == "MGSDS")
            {
                totalFee = (1.5f * tuition) + bus;
            }
            else if (studentType == "MGSH")
            {
                totalFee = (1.5f * tuition) + hostel;
            }
            Console.WriteLine("The fees to be paid by the student is Rs.{0}",totalFee);
        }
    }
}
