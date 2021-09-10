using System.ComponentModel.DataAnnotations;

namespace Blazor.Data;
public class Product {
  public int id {get; set;}

  [StringLength(100)]
  public string name { get; set; }

  [Required]
  public int amount {get; set;}

  [Required]
  public decimal value {get; set;}

}