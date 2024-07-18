using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace Portfolio.Core.Modal;
public class AchieveMent :EntityBase, IAggregateRoot
{

  [Required]
  public required string CertificateName { get; set; }

  [Required]
  public required string CertificateUrl { get; set; }

  public string? Description { get; set; }

  [ForeignKey(nameof(Users))]
  public required int CreadtedBy { get; set; }

  public DateTime CreatedDate { get; set; }

  public bool? IsDeleted { get; set; }

  public bool? IsDeletedBy { get; set; }
  public DateTime? ModifiedDate { get; set; }
}
