namespace PodCastWorld;

/// <summary>
/// USER CLASS: stores and makes retrievable data 
/// 
/// </summary>
public class User
{
    /// Add the private fields 
    
    /// As a user, I want to register for the application by providing my name, age, email address, mobile number, and password, so that I can create a secure account.

    string _name;

    int _age;

    string _email;

    int _mobileNumber;

    string _password;
    // might make private later    
    
    public User(string name, int age, string email, int mobileNumber, string password)
    {
        // Initialisations
        _name = name;
        _age = age;
        _email = email;
        _mobileNumber = mobileNumber;
        _password = password;       
        // ...
    }
}