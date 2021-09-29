using System.ComponentModel.DataAnnotations;

namespace LojaApp.Data;
public class Cliente
{
  public int Id { get; set; }

  public string? Nome { get; set; }

  [Required]
  public int Cpf { get; set; }

  [Required]
  public int Telefone { get; set; }

  [Required]
  public string? Email { get; set; }

  [Required]
  public string? Sexo { get; set; }
  
  [Required]
  public string? EstadoCivil { get; set; }

  [Required]
  public string? Escolaridade { get; set; }

  [Required]
  public string? DataNascimento { get; set; }

  [Required]
  public string? Endereco { get; set; }
}