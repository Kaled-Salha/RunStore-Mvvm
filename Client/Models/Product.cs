using System;

namespace Client.Models;

public record class Product
{
  public string Id { get; set; } = Guid.NewGuid().ToString();

  public string? Description { get; set; }
  public string? Image { get; set; }
  public required string itemNumber { get; set; }
  public required string Name { get; set; }
  public required string SupplierName { get; set; }
  public int Price { get; set; }

}
