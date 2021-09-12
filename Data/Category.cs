using System.ComponentModel.DataAnnotations;

namespace Blazor.Data;
public class Category {
  public int Id { get; set; }
  
  [StringLength(255)]
  public string? description { get; set; }

  public List<Product>? Product {get; set;}
}