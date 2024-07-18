using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ardalis.SharedKernel;

namespace Portfolio.Core.Modal;
public class Projects : EntityBase, IAggregateRoot
{
  public required string ProjectName { get; set; }
  public string? ProjectLongDescription { get; set;} = string.Empty;
  public required string ProjectTitle { get; set; }
  public string? ProjectShortDescription { get; set; } = string.Empty;
  public string? ProjectURL { get; set; } = string.Empty;

  public string? ProjectImageUrl { get; set; } = string.Empty;

  [ForeignKey(nameof(ProjectsType))]
  [Required]
  public int ProjectsTypeId { get; set; }

  [ForeignKey(nameof(ProjectTechnologies))]
  [Required]
  public int ProjectTechnologies { get; set; }
  public bool? IsStatus { get; set; }

  [ForeignKey(nameof(Users))]
  public required int CreadtedBy { get; set;}

  public DateTime CreatedDate { get; set;}

  public bool? IsDeleted { get; set;}

  public bool? IsDeletedBy { get; set;}
  public DateTime? ModifiedDate { get; set;}
}
