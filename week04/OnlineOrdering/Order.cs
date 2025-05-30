using System;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalProductCost = 0m;

        foreach (Product product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        decimal shippingCost;
        if (_customer.LivesInUSA())
        {
            shippingCost = 5m;
        }
        else
        {
            shippingCost = 35m;
        }

        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabelBuilder = new StringBuilder();
        packingLabelBuilder.AppendLine("--- Packing Label ---");

        if (_products.Count == 0)
        {
            packingLabelBuilder.AppendLine("No products in this order.");
        }
        else
        {
            foreach (Product product in _products)
            {
                packingLabelBuilder.AppendLine($"Product Name: {product.GetName()}, ID: {product.GetProductId()}");
            }
        }
        return packingLabelBuilder.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder shippingLabelBuilder = new StringBuilder();
        shippingLabelBuilder.AppendLine("--- Shipping Label ---");
        shippingLabelBuilder.AppendLine($"To: {_customer.GetName()}");
        shippingLabelBuilder.AppendLine(_customer.GetAddress().GetFullAddressString());
        return shippingLabelBuilder.ToString();
    }
}