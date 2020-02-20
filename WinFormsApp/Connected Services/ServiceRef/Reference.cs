﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceRef
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRef.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HelloWorld", ReplyAction="http://tempuri.org/IService1/HelloWorldResponse")]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/HelloWorld", ReplyAction="http://tempuri.org/IService1/HelloWorldResponse")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        int Add(int[] listInt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int[] listInt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Fibonacci", ReplyAction="http://tempuri.org/IService1/FibonacciResponse")]
        int Fibonacci(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Fibonacci", ReplyAction="http://tempuri.org/IService1/FibonacciResponse")]
        System.Threading.Tasks.Task<int> FibonacciAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetXmlData", ReplyAction="http://tempuri.org/IService1/GetXmlDataResponse")]
        string GetXmlData(string xmlContent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetXmlData", ReplyAction="http://tempuri.org/IService1/GetXmlDataResponse")]
        System.Threading.Tasks.Task<string> GetXmlDataAsync(string xmlContent);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IService1Channel : ServiceRef.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceRef.IService1>, ServiceRef.IService1
    {
        
        /// <summary>
        /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
        /// </summary>
        /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
        /// <param name="clientCredentials">Informations d'identification du client</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string HelloWorld()
        {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync()
        {
            return base.Channel.HelloWorldAsync();
        }
        
        public int Add(int[] listInt)
        {
            return base.Channel.Add(listInt);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int[] listInt)
        {
            return base.Channel.AddAsync(listInt);
        }
        
        public int Fibonacci(int n)
        {
            return base.Channel.Fibonacci(n);
        }
        
        public System.Threading.Tasks.Task<int> FibonacciAsync(int n)
        {
            return base.Channel.FibonacciAsync(n);
        }
        
        public string GetXmlData(string xmlContent)
        {
            return base.Channel.GetXmlData(xmlContent);
        }
        
        public System.Threading.Tasks.Task<string> GetXmlDataAsync(string xmlContent)
        {
            return base.Channel.GetXmlDataAsync(xmlContent);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Service1");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}