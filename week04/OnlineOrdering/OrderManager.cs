using System;
using System.Collections.Generic;
public class OrderManager
{
    private List<Order> _orders;
    public OrderManager()
    {
        _orders = new List<Order>();
    }
    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }
    public void DisplayOrders()
    {
        int orderNumber = 1;
        foreach (Order order in _orders)
        {
            Console.WriteLine($"ORDER {orderNumber}");
            Console.WriteLine("※※※※※※※※※※※※※※※※※※※※※");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
            Console.WriteLine("※※※※※※※※※※※※※※※※※※※※※");
            Console.WriteLine();

            orderNumber++;
        }
    }

}