using System.Diagnostics.Contracts;
using System.Text;

public class Product {
    private string _productName; 
    private string _productId; 
    private double _price;
    private double _quantity; 

    public Product(string productName, string productId, double price, double quantity)
    {
        _productName = productName;
        _productId = productId; 
        _price = price;
        _quantity = quantity; 
    }

    public double CostOfProduct()
    {
        return _price * _quantity; 
    }
    public double GetPrice()
    {
        return _price; 
    }
    public string GetProductName()
    {
        return _productName; 
    }
    public string GetProductId()
    {
        return _productId;
    }

}