using System;

namespace Client.Models;

public record class Customer
{

  public string Id { get; set; } = Guid.NewGuid().ToString();

  public required string firstName { get; set; }
  public required string lastName { get; set; }
  public required string Email { get; set; }
  public required string Adress { get; set; }
  public string? phoneNumber { get; set; }


}
