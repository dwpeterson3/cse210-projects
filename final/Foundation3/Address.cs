public class Address {
    private string _street;
    private string _city;
    private string _state; 
    private string _zipCode; 

    public Address(string street, string city, string state, string zipCode)
    {
        _street = street; 
        _city = city; 
        _state = state;
        _zipCode = zipCode; 
    }
    public string AddressString()
    {
        return $"{_street}, {_city}, {_state}, {_zipCode}"; 
    }
    public override string ToString()
    {
        return AddressString(); 
    }
}