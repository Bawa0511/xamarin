using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string course_code;
            double CA_obtainedMarks, CA_obtainedActualMarks, MTT_obtainedMarks, ETE_obtainedMarks;
            double CA_TotalMarks = 100, MTT_TotalMarks = 40, ETE_TotalMarks = 70;
            double CA_Wtg = 25;
            double MTT_Wtg = 20;
            double ETE_Wtg = 50;
            double Att = 5;
            
            Console.WriteLine("Enter course code");
            course_code=Console.ReadLine();
            Console.WriteLine("Enter CA Marks");
            CA_obtainedMarks=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter MTT Marks");
            MTT_obtainedMarks=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter ETE Marks");
            ETE_obtainedMarks=double.Parse(Console.ReadLine());
            CA_obtainedActualMarks = (CA_obtainedMarks * 60) / 100;
            double total = (CA_obtainedActualMarks * CA_Wtg) / CA_TotalMarks + (MTT_obtainedMarks * MTT_Wtg) / MTT_TotalMarks + (ETE_obtainedMarks * ETE_Wtg) / ETE_TotalMarks + Att;
            
            Console.WriteLine("Total Percentage" + total);
            Console.WriteLine("CGPA:" + total / 10);
            Console.ReadKey();
        }
    }
}
