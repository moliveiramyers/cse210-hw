using System;

public class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _quantity;
    private double _total;

    public Product(string productName, int productId, double productPrice, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _quantity = quantity;
        _total = _quantity*_productPrice;

    }

    public string ProductDisplay()
    {
        return $"ID{_productId}: {_productName}";
    }

    public string GetName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public double GetProductPrice()
    {
        return _productPrice;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetTotal()
    {
        return _total;
    }

}