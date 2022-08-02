using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07Example
{
    class School
    {
        public string strSchoolName;
        private string strAddress;
        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        public School(string strSchoolName, string strAddress)
        {
            this.strSchoolName = strSchoolName;
            this.strAddress = strAddress;
        }
        class Student : School
        {
            public string strStudentName;
            private float fltSchoolFees;

            public float FltSchoolFees
            {
                get { return fltSchoolFees; }
                set { fltSchoolFees = value; }
            }
            public Student(string strStudentName,
                           float fltSchoolFeees,
                           string strSchoolName,
                           string strAddress) : base (strSchoolName, strAddress)
            {
                this.strStudentName = strStudentName;
                this.fltSchoolFees = fltSchoolFeees;

            }
        }
        static void Main(string[] args)
        {
            Student objS1;
            Console.Write("Enter the school:");
            string MySchool = Console.ReadLine();
            Console.Write("Enter the adress:");
            String myAdress = Console.ReadLine();
            Console.Write("Enter the student's name :");
            string myname=Console.ReadLine();
            Console.Write("Enter the school fees:");
            float myschoolfees=float.Parse(Console.ReadLine());

            objS1 = new Student(myname, myschoolfees,MySchool, myAdress);

            Console.WriteLine("School name: {0}", objS1.strSchoolName);
            Console.WriteLine("Address: {0}", objS1.Address);
            Console.WriteLine("Student Name: {0}", objS1.strStudentName);
            Console.WriteLine("School Fees: {0}", objS1.FltSchoolFees);


           
        }
    }
}
