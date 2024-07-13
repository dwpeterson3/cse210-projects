using System.Net.Sockets;

public class Customer {
    private string _customerName; 
    private Address _address;
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool IsDomesticCustomer()
    {
        return _address.IsDomestic(); 
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    public Address GetAddress()
    {
        return _address; 
    }


}