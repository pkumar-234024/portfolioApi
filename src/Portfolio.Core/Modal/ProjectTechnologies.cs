using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace Portfolio.Core.Modal;
public  class ProjectTechnologies : EntityBase, IAggregateRoot
{

  public string Technology { get; set; } = string.Empty;

  public string ForntEndTechnology { get; set; } = string.Empty;

  public string BackENdTechnology { get; set; } = string.Empty;

  public string DatabseTechnology { get; set; } = string.Empty;

  public DateTime CreatedDate { get; set; }

  public bool? IsDeleted { get; set; }

  public bool? IsDeletedBy { get; set; }
  public DateTime? ModifiedDate { get; set; }

  public virtual Projects? Projects { get; set; }
}
