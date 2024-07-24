using System.ComponentModel.DataAnnotations;
using Ardalis.SharedKernel;

namespace Portfolio.Core.Modal;

public class Users : EntityBase, IAggregateRoot
{
  //public Users()
  //{

  //}
  [Required]
  public required string FirstName { get; set; }

  [Required]
  public  required string LastName { get; set; }

  public string? FullName { get; set; } = string.Empty;

  public string? City { get; set; } = string.Empty;

  public string? State { get; set; } = string.Empty;

  public string? PinCode { get; set; } = string.Empty;

  public string? Country { get; set; } = string.Empty;  
  [Required]
  public required string? Email { get; set; }
 
  public int? UserId { get; set; }
  public string? Password { get; set; } = string.Empty;
  public string? ContactNumber { get; set; } = string.Empty;

  public int? CreadtedBy { get; set; }

  public DateTime CreatedDate { get; set; }

  public bool? IsDeleted { get; set; }

  public bool? IsDeletedBy { get; set; }
  public DateTime? ModifiedDate { get; set; }


  public virtual IEnumerable<Projects> Projects {get;set;} = new List<Projects>();
  public virtual SocialMediaAccount? SocialMediaAccount { get; set; }
  public virtual UserDocument? UserDocument { get; set; }
  public virtual Educations? Educations { get; set; }
  public virtual Experience? Experience { get; set; }
  public virtual AchieveMent? AchieveMent { get; set; }

  public virtual About? About { get; set; }

  public virtual Skills? Skills { get; set; }
}
