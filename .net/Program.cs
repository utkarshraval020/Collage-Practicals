
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.GetStudentDetails();
            S1.Scholarship_Calculation();
            S1.DisplayStudentData();
        }
    }

    public class Student
    {
        public int Admission_no;
        public string Name;
        public string Course;
        public int Semester;
        private int fees;
        private string eligibility;
        private int Scholarship;
        private const int Scholarship_Rate = 10;

        public void GetStudentDetails()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Student Admission System");
            Console.WriteLine("=========================");

            Console.Write("Enter Admission Number: ");
            Admission_no = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Course: ");
            Course = Console.ReadLine();

            Console.Write("Enter Sem: ");
            Semester = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Admission Fees: ");
            fees = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayStudentData()
        {
            Console.WriteLine("\n\n\n" +
                "" +
                "=========================");
            Console.WriteLine("Student Admission Details");
            Console.WriteLine("=========================");
            Console.WriteLine("Admission Number: " + Admission_no);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("Sem: " + Semester);
            Console.WriteLine("Fees: " + fees);
            Console.WriteLine("Scholarship: " + eligibility);
            Console.WriteLine("Fees to be paid: " + Scholarship);
        }

        public void Scholarship_Calculation()
        {
            if (fees >= 45000)
            {
                eligibility = "You Are Eligible";
                Scholarship = fees - ((fees * Scholarship_Rate) / 100);
            }
            else
            {
                eligibility = "You Are Not Eligible";
                Scholarship = fees;
            }
        }
    }
}
