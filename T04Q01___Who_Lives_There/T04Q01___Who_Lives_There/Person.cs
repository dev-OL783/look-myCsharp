namespace T04Q01___Who_Lives_There;
/// <summary>
/// A class containing a person's name and the city where they live.
/// </summary>
public class Person
{
    /// <summary>
    /// The person's name.
    /// </summary>
    private string _name;
    private int _age;
    private string _city;

    // Create fields for a person's age and city
    /// <summary>
    /// The constructor with name, age city parameters.
    /// </summary>

    /// <param name="name">The person's name.</param>
    /// <param name="age">The person's age.</param>
    /// <param name="city">The person's city.</param>
    public Person(string name, int age, string city)
    {
        _name = name;
        _age = age;
        _city = city;
        // Add the initialisation statements for the age and city fields with the parameters' values 
    }

    /// <summary>
    /// Returns the person's name. 
    /// </summary>
    /// <returns>The field Name.</returns>
    public string GetName()
    {
        return _name;
    }

    // Repeat the GetName() template for the other two fields 

    /// <summary>
    /// Returns the persons age.
    /// </summary>
    /// <returns>The field City.</returns>
    public int GetAge()
    {
        // Replace with the correct code
        return _age;
    }

    /// <summary>
    /// Returns the persons city.
    /// </summary>
    /// <returns>The field City.</returns>

    public string GetCity()
    {
        // Replace with the correct code
        return _city;
    }

}