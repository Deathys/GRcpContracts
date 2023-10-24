using System;
using Grpc.Core;

namespace GRcpContract.Exceptions;

public class MyCustomRpcException : RpcException
{
    public string ErrorMessage { get; set; }

    public MyCustomRpcException(Status status) : base(status)
    {
    }

    public MyCustomRpcException(Status status, string message, string errorMessage) : base(status, message)
    {
        ErrorMessage = errorMessage;
    }

    public MyCustomRpcException(Status status, Metadata trailers) : base(status, trailers)
    {
    }

    public MyCustomRpcException(Status status, Metadata trailers, string message) : base(status, trailers, message)
    {
    }
}