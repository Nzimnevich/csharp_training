namespace WebAddressbookTests;

public class ContactData
{
    private string name;
    private string lastname;

    public ContactData(string name, string lastname)
    {
        this.name = name;
        this.lastname = lastname;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Lastname
    {
        get => lastname;
        set => lastname = value;
    }
}