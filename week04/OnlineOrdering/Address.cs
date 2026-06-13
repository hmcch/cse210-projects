public class Address
{
    //Private members variables to store address data
    //By being private the encapsulation is applied
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //The Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //Method to check if the address is in the USA
    public bool IsInUSA()
    {
        //Converting to lowercase before comparison to prevent bugs related with typing
        return _country.ToLower() == "usa";
    }

    //Method to return a single formatted string of the entire address
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}