public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }


    public bool LivingInUSA()
    {
        return _address.LivingInUSA();
    }

    public string CustomerName()
    {
        return $"{_name}";
    }
    public string PrintAddress()
    {
        return $"{_address.PrintAddress()}";
    }
}