using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathsS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMaths" in both code and config file together.
    [ServiceContract]
    public interface IMaths
    {
        [OperationContract]
        int add(int x, int y);
        [OperationContract]
        int subt(int x, int y);

        [OperationContract]
        int prodcut(int x, int y);

        [OperationContract]
        [FaultContract(typeof(CustomFaultDetails))]
        int div(int x, int y);
        [OperationContract]
        List<Student> GetStudents();
        [OperationContract]
        Student GetStudentById(int id);

    }
}
