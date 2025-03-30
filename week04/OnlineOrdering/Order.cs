public class Order 
{
    
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }


    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double totalCost = 0;
        for (int i = 0; i < _products.Count; i++)
        {
            totalCost += _products[i].TotalCost();
        }
        if (_customer.LivingInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string PrintPackingLabel()
    {
        string packingLabel = "";
        for (int i = 0; i < _products.Count; i++)
        {
            packingLabel += $"{_products[i].PackingLabel()}\n";
        }
        return packingLabel;
    }

    public string PrintShippingLabel()
    {
        return $"{_customer.CustomerName()}\n{_customer.PrintAddress()}";
    }
}