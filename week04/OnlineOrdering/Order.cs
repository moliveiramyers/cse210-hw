using System;

public class Order
{
    private  Product _product;
    private Customer _customerDetails;
    private Address _shippingAddress;
    private List<String>_productsList = new List<string>(); 
    private double _total = 0;

    public Order()
    {
        

    }

    public void SetProductToList(Product product)
    {
        
        _productsList.Add(product.ProductDisplay());
        _total = _total + product.GetTotal();
        
    
    }

    public double Total(Customer customer)
    {
        
        if (!customer.usaOrNot())
        {
            _total += 35;
        }
        else
        {
            _total += 5; 
        }
        return _total;

    }

    public void packingLabel()
    {
        foreach (string item in _productsList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(Math.Round(_total,2 ));
    }

    public void shippingLabel(Customer customer)
    {
        Console.WriteLine(customer.getCustomerName()) ;
        Console.WriteLine(customer.getCustomerAddress());
    }



}