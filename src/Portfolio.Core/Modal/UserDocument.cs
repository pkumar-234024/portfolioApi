using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace Portfolio.Core.Modal;
public class UserDocument : EntityBase, IAggregateRoot
{
  public string? ImageUrl { get; set; } = string.Empty;

  public string? ResumeUrl { get; set; } = string.Empty;

  public string? CvUrl { get; set; } = string.Empty;

  [ForeignKey(nameof(Users))]
  public required int CreadtedBy { get; set; }

  public DateTime CreatedDate { get; set; }

  public bool? IsDeleted { get; set; }

  public bool? IsDeletedBy { get; set; }
  public DateTime? ModifiedDate { get; set; }
}
