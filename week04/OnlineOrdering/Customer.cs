using System;

public class Customer
{
    private string _customerName;
    private string _customerAddress ;
    private Address _address ;

    public Customer(string customerName, Address address)
    {
        _customerName =  customerName;
        _customerAddress = address.GetDisplay();
        _address = address;
        

    }
    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        return _customerAddress;
    }

    public bool UsaOrNot()
    {
        return _address.UsaIdentifier();
    }

}