using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace Portfolio.Core.Modal;
public class Client : EntityBase, IAggregateRoot
{
  public DateTime CreatedDate { get; set; }

  public bool? IsDeleted { get; set; }

  public bool? IsDeletedBy { get; set; }
  public DateTime? ModifiedDate { get; set; }
}
