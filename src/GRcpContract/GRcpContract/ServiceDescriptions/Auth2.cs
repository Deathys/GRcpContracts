using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using ProtoBuf.Grpc;

namespace GRcpContract.ServiceDescriptions;


[ServiceContract(Namespace = "Auth")]
public interface IAuth2
{
    [OperationContract]
    Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CallContext context = default)
    {
        return Task.FromResult((UpdateUserResponse)null);
    }
}

[DataContract] 
public class UpdateUserRequest
{
    [DataMember(Order = 1, IsRequired = true )]
    public Guid UserId { get; set; }
    
    [DataMember(Order = 2)]
    public string Name { get; set; }
    
    [JsonConverter(typeof(StringEnumConverter))]
    [DataMember(Order = 3)]
    public EUserStatus Status { get; set; }
}

[DataContract]
public class UpdateUserResponse
{
    [DataMember(Order = 1)]
    public bool Success { get; set; }
}