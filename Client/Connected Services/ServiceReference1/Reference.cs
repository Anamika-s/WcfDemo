//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/MathsS")]
    public partial class CustomFaultDetails : object
    {
        
        private string ErrorDetailsField;
        
        private string ErrorIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorDetails
        {
            get
            {
                return this.ErrorDetailsField;
            }
            set
            {
                this.ErrorDetailsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorID
        {
            get
            {
                return this.ErrorIDField;
            }
            set
            {
                this.ErrorIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/MathsS")]
    public partial class Student : object
    {
        
        private int idField;
        
        private int marksField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int marks
        {
            get
            {
                return this.marksField;
            }
            set
            {
                this.marksField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMaths")]
    public interface IMaths
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/add", ReplyAction="http://tempuri.org/IMaths/addResponse")]
        int add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/add", ReplyAction="http://tempuri.org/IMaths/addResponse")]
        System.Threading.Tasks.Task<int> addAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/subt", ReplyAction="http://tempuri.org/IMaths/subtResponse")]
        int subt(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/subt", ReplyAction="http://tempuri.org/IMaths/subtResponse")]
        System.Threading.Tasks.Task<int> subtAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/prodcut", ReplyAction="http://tempuri.org/IMaths/prodcutResponse")]
        int prodcut(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/prodcut", ReplyAction="http://tempuri.org/IMaths/prodcutResponse")]
        System.Threading.Tasks.Task<int> prodcutAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/div", ReplyAction="http://tempuri.org/IMaths/divResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReference1.CustomFaultDetails), Action="http://tempuri.org/IMaths/divCustomFaultDetailsFault", Name="CustomFaultDetails", Namespace="http://schemas.datacontract.org/2004/07/MathsS")]
        int div(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/div", ReplyAction="http://tempuri.org/IMaths/divResponse")]
        System.Threading.Tasks.Task<int> divAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/GetStudents", ReplyAction="http://tempuri.org/IMaths/GetStudentsResponse")]
        ServiceReference1.Student[] GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/GetStudents", ReplyAction="http://tempuri.org/IMaths/GetStudentsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Student[]> GetStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/GetStudentById", ReplyAction="http://tempuri.org/IMaths/GetStudentByIdResponse")]
        ServiceReference1.Student GetStudentById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMaths/GetStudentById", ReplyAction="http://tempuri.org/IMaths/GetStudentByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Student> GetStudentByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMathsChannel : ServiceReference1.IMaths, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MathsClient : System.ServiceModel.ClientBase<ServiceReference1.IMaths>, ServiceReference1.IMaths
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MathsClient() : 
                base(MathsClient.GetDefaultBinding(), MathsClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMaths.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathsClient(EndpointConfiguration endpointConfiguration) : 
                base(MathsClient.GetBindingForEndpoint(endpointConfiguration), MathsClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathsClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MathsClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathsClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MathsClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public int add(int x, int y)
        {
            return base.Channel.add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> addAsync(int x, int y)
        {
            return base.Channel.addAsync(x, y);
        }
        
        public int subt(int x, int y)
        {
            return base.Channel.subt(x, y);
        }
        
        public System.Threading.Tasks.Task<int> subtAsync(int x, int y)
        {
            return base.Channel.subtAsync(x, y);
        }
        
        public int prodcut(int x, int y)
        {
            return base.Channel.prodcut(x, y);
        }
        
        public System.Threading.Tasks.Task<int> prodcutAsync(int x, int y)
        {
            return base.Channel.prodcutAsync(x, y);
        }
        
        public int div(int x, int y)
        {
            return base.Channel.div(x, y);
        }
        
        public System.Threading.Tasks.Task<int> divAsync(int x, int y)
        {
            return base.Channel.divAsync(x, y);
        }
        
        public ServiceReference1.Student[] GetStudents()
        {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Student[]> GetStudentsAsync()
        {
            return base.Channel.GetStudentsAsync();
        }
        
        public ServiceReference1.Student GetStudentById(int id)
        {
            return base.Channel.GetStudentById(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Student> GetStudentByIdAsync(int id)
        {
            return base.Channel.GetStudentByIdAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMaths))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMaths))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/MathsS/Maths/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MathsClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMaths);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MathsClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMaths);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMaths,
        }
    }
}
