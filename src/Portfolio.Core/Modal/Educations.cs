using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ardalis.SharedKernel;

namespace Portfolio.Core.Modal;
public class Educations:EntityBase, IAggregateRoot
{
  [Required]
  public required string Education { get; set; }

  [Required]
  public required string UniversityOrInstitute { get; set; }

  [Required]
  public required string Course { get; set; }

  [Required]
  public required string Specialization { get; set; }

  [Required]
  public required string CourseType { get; set; }

  [Required]
  public required string CourseDurationFrom { get; set; }

  [Required]
  public required string CourseDurationFromTo { get; set; }

  [Required]
  public required string Marks { get; set; }

  [ForeignKey(nameof(Users))]
  public required int CreadtedBy { get; set; }

  public DateTime CreatedDate { get; set; }

  public bool? IsDeleted { get; set; }

  public bool? IsDeletedBy { get; set; }
  public DateTime? ModifiedDate { get; set; }
}
