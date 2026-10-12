using System;
using Client.Repositories;
using System.Text.Json;

namespace Client.Models;

public record class Product
{
  public string Id { get; set; } = Guid.NewGuid().ToString();

  public string? Description { get; set; }
  public string? Image { get; set; }
  public required string ItemNumber { get; set; }
  public required string Name { get; set; }
  public required string SupplierName { get; set; }
  public int Price { get; set; }


  public void Edit()
  {
    Console.WriteLine("Ändra produktuppgifter");
  }

  public void Delete()
  {
    Console.WriteLine("Ta bort produkten");
  }

}
