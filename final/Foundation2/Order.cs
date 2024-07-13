using System.Net.Http.Headers;

public class Order{
    private Customer _customer;
    private List<Product> _products;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>(); 
    }

    public double CostOfOrder()
    {
        double totalCost = 0; 
        foreach (Product product in _products)
        {
            totalCost += product.CostOfProduct(); 
        }

        totalCost += _customer.IsDomesticCustomer() ? 5 : 35; 

        return totalCost; 

    }
    public void AddProduct(Product product)
    {
        _products.Add(product); 
    }
    public string PackingLabel()
    {
        string label = "Packing Label:\n"; 
        foreach (Product product in _products)
        {
            label += $"Name: {product.GetProductName()}, Product ID: {product.GetProductId()}\n";
        }
        
        return label; 

    }
    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerName()}\n{_customer.GetAddress().AddressString()}";
    }
}