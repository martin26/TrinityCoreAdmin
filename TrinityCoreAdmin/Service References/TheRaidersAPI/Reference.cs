﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18052
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrinityCoreAdmin.TheRaidersAPI
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://localhost/TheRaidersAPI/", ConfigurationName = "TheRaidersAPI.TheRaidersAPISoap")]
    public interface TheRaidersAPISoap
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/TheRaidersAPI/SayHello", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        string SayHello(string name);

        [System.ServiceModel.OperationContractAttribute(Action = "http://localhost/TheRaidersAPI/HelloWorld", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults = true, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        string HelloWorld(string name);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TheRaidersAPISoapChannel : TrinityCoreAdmin.TheRaidersAPI.TheRaidersAPISoap, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TheRaidersAPISoapClient : System.ServiceModel.ClientBase<TrinityCoreAdmin.TheRaidersAPI.TheRaidersAPISoap>, TrinityCoreAdmin.TheRaidersAPI.TheRaidersAPISoap
    {
        public TheRaidersAPISoapClient()
        {
        }

        public TheRaidersAPISoapClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public TheRaidersAPISoapClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public TheRaidersAPISoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public TheRaidersAPISoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public string SayHello(string name)
        {
            return base.Channel.SayHello(name);
        }

        public string HelloWorld(string name)
        {
            return base.Channel.HelloWorld(name);
        }
    }
}