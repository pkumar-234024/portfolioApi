using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ardalis.SharedKernel;

namespace Portfolio.Core.Modal;
public class About : EntityBase, IAggregateRoot
{
  [Required]
  public required string Summary { get; set; }

  [Required]
  public required string Designation { get; set; }

  [Required]
  public required string Role { get; set; }

  public string? FluentIn { get; set; } = string.Empty;

  public string? FieldOfInterest { get; set; } = string.Empty;

  public string? FieldOfInterestOthers { get; set; } = string.Empty;

  public string? PassionFor { get; set; } = string.Empty;

  public string? Acticity { get; set; } = string.Empty;

  [ForeignKey(nameof(Users))]
  public required int CreadtedBy { get; set; }

  public DateTime? CreatedDate { get; set; }

  public bool? IsDeleted { get; set; }

  public bool? IsDeletedBy { get; set; }
  public DateTime? ModifiedDate { get; set; }
}
