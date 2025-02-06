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
    public string getCustomerName()
    {
        return _customerName;
    }

    public string getCustomerAddress()
    {
        return _customerAddress;
    }

    public bool usaOrNot()
    {
        return _address.usaIdentifier();
    }

}