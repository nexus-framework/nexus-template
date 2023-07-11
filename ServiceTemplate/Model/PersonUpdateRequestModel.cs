namespace {{RootNamespace}}.Model;

[ExcludeFromCodeCoverage]
public class PersonUpdateRequestModel
{
    required public string Name { get; set; }
    
    required public string Email { get; set; }
}