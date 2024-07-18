using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Ardalis.SharedKernel;

namespace Portfolio.Core.Modal;
public class ProjectsType : EntityBase, IAggregateRoot
{
  [Required]
  public required string ProjectType { get; set; }


  public DateTime? CreatedDate { get; set; }
  public int? CreadtedBy { get; set; }
  public bool? IsDeleted { get; set; }

  public bool? IsDeletedBy { get; set; }
  public DateTime? ModifiedDate { get; set; }

  public virtual Projects? Projects { get; set; }
}
