namespace Client;

public record class Customer
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public int ZipCode { get; set; }

}
