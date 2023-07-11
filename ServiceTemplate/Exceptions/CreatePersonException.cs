namespace {{RootNamespace}}.Exceptions;

public class CreatePersonException : Exception
{
    public const string ExceptionMessage = "Error trying to create a person";
    
    public CreatePersonException(Exception ex)
        : base(ExceptionMessage, ex)
    {
    }
}
