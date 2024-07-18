using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ardalis.SharedKernel;

namespace Portfolio.Core.Modal;
public class Experience:EntityBase, IAggregateRoot
{
  [Required]
  public required bool CurrewntEmployee { get; set; }
  [Required]
  public required string EmploymentType { get; set; }
  [Required]
  public required string CurrentCompantyName { get; set; }
  [Required]
  public required string Location { get; set; }
  [Required]
  public required string Department { get; set; }

  public string? RoleCategory { get; set; } = string.Empty;
  [Required]
  public required string Role { get; set; }
  [Required]
  public required string WorkingFrom { get; set; }
  public string? WorkingTo { get; set; } = string.Empty;


  [ForeignKey(nameof(Users))]
  public required int CreadtedBy { get; set; }

  public DateTime CreatedDate { get; set; }

  public bool? IsDeleted { get; set; }

  public bool? IsDeletedBy { get; set; }
  public DateTime? ModifiedDate { get; set; }
}
