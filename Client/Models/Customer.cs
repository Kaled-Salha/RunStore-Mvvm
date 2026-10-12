using System;

namespace Client.Models;

public record class Customer
{

  public string Id { get; set; } = Guid.NewGuid().ToString();

  public required string firstName { get; set; }
  public required string lastName { get; set; }
  public required string Email { get; set; }
  public string? phoneNumber { get; set; }
  public string? Adress { get; set; }
  public string? postalCode { get; set; }
  public string? City { get; set; }

  public void Edit()
  {
    Console.WriteLine("Ändra kunduppgifter");
  }

  public void Delete()
  {
    Console.WriteLine("Ta bort kund");
  }

}
