using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using ProtoBuf.Grpc;

namespace GRcpContract.ServiceDescriptions;


[ServiceContract(Namespace = "Auth")]
public interface IAuth
{
    [OperationContract]
    Task<GetUserResponse> GetUserAsync(GetUserRequest request, CallContext context = default)
    {
        return Task.FromResult((GetUserResponse)null);
    }
}

[DataContract] 
public class GetUserRequest
{
    [DataMember(Order = 1)]
    public Guid UserId { get; set; }
}

[DataContract]
public class GetUserResponse
{
    [DataMember(Order = 1)]
    public Guid UserId { get; set; }

    [DataMember(Order = 2)]
    public string Name { get; set; }

    [DataMember(Order = 3)]
    public DateTime Created { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    [DataMember(Order = 4)]
    public EUserStatus Status { get; set; }
}

public enum EUserStatus
{
    None,
    Active,
    Deleted,
    Frozen,
}