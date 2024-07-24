using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace Portfolio.Core.Modal;
public class ErrorLogs :EntityBase,IAggregateRoot
{
  public string? Message { get; set; }
  public string? InnerMessage { get; set; }
  [Required]
  public required string Description { get; set; }
  public string? ContollerName {  get; set; }

  public int? CreadtedBy { get; set; }

  public DateTime? CreatedDate { get; set; }

  public bool? IsDeleted { get; set; }

  public bool? IsDeletedBy { get; set; }
  public DateTime? ModifiedDate { get; set; }
}
