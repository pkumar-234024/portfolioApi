using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Portfolio.Core.ContributorAggregate;

namespace Portfolio.Core.Modal;

public class Users : EntityBase, IAggregateRoot
{
  [Required]
  public string FirstName { get; set; }

  [Required]
  public  string LastName { get; set; }

  public string? FullName { get; set; } = string.Empty;

  public string? City { get; set; } = string.Empty;

  public string? State { get; set; } = string.Empty;

  public string? PinCode { get; set; } = string.Empty;

  public string? Country { get; set; } = string.Empty;

  [Required]
  public required string Summary { get; set; } = string.Empty;


  [Required]
  public required string? Email { get; set; }

  [Required]
  public required string? UserId { get; set; }
  public string? Password { get; set; } = string.Empty;

  public string? ContactNumber { get; set; } = string.Empty;

  



  public Users(string firstName, string lastName)
  {
    FirstName = Guard.Against.NullOrEmpty(firstName, nameof(firstName));
    LastName = Guard.Against.NullOrEmpty(lastName, nameof(lastName));
  }

  public void UpdateFirstName(string newFirstName)
  {
    FirstName = Guard.Against.NullOrEmpty(newFirstName, nameof(newFirstName));
  }
  public void UpdateLasttName(string newLastName)
  {
    LastName = Guard.Against.NullOrEmpty(newLastName, nameof(newLastName));
  }

  public virtual IEnumerable<Projects> Projects {get;set;} = new List<Projects>();
  public virtual IEnumerable<SocialMediaAccount> SocialMediaAccount { get; set; } = new List<SocialMediaAccount>();
  public virtual IEnumerable<UserDocument> UserDocument { get; set; } = new List<UserDocument>();
}
