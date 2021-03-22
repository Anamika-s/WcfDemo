using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MathsS
{
    [DataContract]
    public class CustomFaultDetails
    {
        [DataMember]
        public string ErrorID { get; set; }

        [DataMember]
        public string ErrorDetails { get; set; }
    }

}
