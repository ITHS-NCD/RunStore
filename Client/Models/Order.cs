using System;

namespace Client.Models;

public class Order
{
    public string OrderNumber { get; set; } = Guid.NewGuid().ToString();
    public string? OrderDate { get; set; }
    public required int Quantity { get; set; }
    public required string OrderProduct { get; set; }

}
