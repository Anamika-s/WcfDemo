using System;
using System.Collections.Generic;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ServiceReference1.MathsClient x = new ServiceReference1.MathsClient();
            try
            {
                Console.WriteLine("Sum is " + x.add(10, 20));
                Console.WriteLine("Difference is " + x.subt(10, 20));

                Console.WriteLine("Product is " + x.prodcut(10, 20));

                Console.WriteLine("Quotient is " + x.div(10, 0));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            ServiceReference1.Student  student = new ServiceReference1.Student();

            student = x.GetStudentById(2);
            Console.WriteLine(student.name);

            List<ServiceReference1.Student> list = new List<ServiceReference1.Student>();

            
            

        }

    }
}
