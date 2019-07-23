using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            MySingleton myCoolSingleton = MySingleton.Instance;
            myCoolSingleton.PrintDetails("heeeelooo you!");
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
            );
            Console.ReadLine();

        }
        
        private static void PrintTeacherDetails()
        {
            MySingleton fromTeacher = MySingleton.Instance;
            fromTeacher.PrintDetails("From Teacher");
            
        }

        private static void PrintStudentdetails()
        {
            MySingleton fromStudent = MySingleton.Instance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
