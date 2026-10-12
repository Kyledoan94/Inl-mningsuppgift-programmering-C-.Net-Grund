namespace  InlämningsUppgift;

public class Person
{
  public string FirstName { get; set; } = "";
  public string LastName {get; set; } = "";
  public string PhoneNumber {get; set;} = "";
  public string PersonalNumber {get; set;} = "";

  public Address HomeAddress { get;} = new Address();
  public override string ToString()
  {
    return $"{GetType().Name}; First Name:{FirstName};Last Name:{LastName}; Telephone Number:{PhoneNumber};Personal Number:{PersonalNumber}; Home Address:{HomeAddress}";
  }
  
}