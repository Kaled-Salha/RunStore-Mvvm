using System;
using System.Collections.Generic;
using Client.Models;

namespace Client.Services;

public class ProductServices
{

  public static List<Product> ListAllProducts()
  {
    return [
      new Product{itemNumber = "1001", Name = "Gel 27", SupplierName = "Asics", Price = 2295},
      new Product{itemNumber = "1002", Name = "Sneakers", SupplierName = "Asics", Price = 1699},
      new Product{itemNumber = "1003", Name = "Maltin", SupplierName = "Asics", Price = 399},
      new Product{itemNumber = "1004", Name = "Magical Hat", SupplierName = "Asics", Price = 9999}
    ];
  }

}
