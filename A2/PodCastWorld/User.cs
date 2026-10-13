namespace PodCastWorld;

/// <summary>
/// USER CLASS: stores and makes retrievable data
/// </summary>
public class User
{
    private string _name;
    private int _age;
    private string _email;
    private string _mobileNumber;
    private string _password;

    public User(string name, int age, string email,
                string mobileNumber, string password)
    {
        _name = name;
        _age = age;
        _email = email;
        _mobileNumber = mobileNumber;
        _password = password;
    }

    // Getters
    public string GetName() => _name;
    public int GetAge() => _age;
    public string GetEmail() => _email;
    public string GetMobileNumber() => _mobileNumber;
    public string GetPassword() => _password;

    // public void SetPassword(string password)
    // {
    //     Password = _password;
    // }
}

