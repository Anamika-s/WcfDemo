using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MathsS
{
   [DataContract]
  public  class Student
    {
        [DataMember]
        public int id { get; set; }
        public string name { get; set; }
        [DataMember]
        public int marks { get; set; }
    
    }
}
