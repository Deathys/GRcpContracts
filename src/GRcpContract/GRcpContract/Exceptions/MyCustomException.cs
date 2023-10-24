using System;

namespace GRcpContract.Exceptions;

public class MyCustomException : Exception
{
    public string ErrorMessage { get; set; }
}