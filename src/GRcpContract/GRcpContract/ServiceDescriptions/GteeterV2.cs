using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;
using ProtoBuf.Grpc;

namespace GRcpContract.ServiceDescriptions
{
    [DataContract]
    public class HelloReply
    {
        [DataMember(Order = 1)]
        public string Message { get; set; }
        
        [DataMember(Order = 2)]
        public Guid AnswerId { get; set; }
        
        [DataMember(Order = 3)]
        public DateTime Created { get; set; }

        [DataMember(Order = 4)]
        public decimal Pos { get; set; }
        
        [DataMember(Order = 5)]
        public decimal Field { get; set; }
    }

    [DataContract]
    public class HelloRequest
    {
        [DataMember(Order = 1)]
        public string Name { get; set; }
        
        [DataMember(Order = 2)]
        public string Field { get; set; }
    }

    [ServiceContract]
    public interface IGreeterV2Service
    {
        [OperationContract]
        Task<HelloReply> SayHelloAsync(HelloRequest request, CallContext context = default);
    }
}