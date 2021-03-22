using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathsS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Maths" in both code and config file together.
    public class Maths : IMaths
    {
        List<Student> studentList;
        public Maths()
        {
            studentList = new List<Student>()
            {
                new Student() { id=1, name="Deepak" ,marks=90},

                new Student() { id=2, name="Pawan" ,marks=78},

                new Student() { id=3, name="Sagar" ,marks=98},

                new Student() { id=4, name="Ajay" ,marks=90},
                new Student() { id=5, name="Vineet" ,marks=78},
                new Student() { id=6, name="Pooja" ,marks=98}
            };
        }
        public int add(int x, int y)
        {
            return x + y;
        }

        public int div(int x, int y)
        {
            int res = 0;
            try
            {
                res = x/ y;
            }
            //catch(Exception ex)
            //{
            //    throw new FaultException(ex.Message);
            //}
            catch
            {
                CustomFaultDetails ex = new CustomFaultDetails();
                ex.ErrorID = "12345";
                ex.ErrorDetails = "Specific error details here.";
                throw new FaultException<CustomFaultDetails>(ex);

            }
            return res;
        }

        public Student GetStudentById(int id)
        {
            Student student = (from temp in studentList
                               where temp.id == id
                               select temp).FirstOrDefault();
            return student;
        }

        public List<Student> GetStudents()
        {
            return studentList;
        }

        public int prodcut(int x, int y)
        {
            return x * y;
        }

        public int subt(int x, int y)
        {
            return x - y;
        }
    }
}
