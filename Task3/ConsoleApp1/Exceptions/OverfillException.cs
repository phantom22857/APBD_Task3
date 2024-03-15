using System.Runtime.Serialization;

namespace ConsoleApp1.Exceptions;

public class OverfillException : Exception
{
    public OverfillException()
    {
    }

    public OverfillException(string? message) : base(message)
    {
    }
}