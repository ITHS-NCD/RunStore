using System;

namespace Client.Models;

public record class Customer
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }

    public void Edit() => Console.WriteLine("Ändra kunduppgifter");
    public void Delete() => Console.WriteLine("Ta bort kund");
}
