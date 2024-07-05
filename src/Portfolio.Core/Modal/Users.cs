using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Portfolio.Core.ContributorAggregate;

namespace Portfolio.Core.Modal;

public class Users : EntityBase, IAggregateRoot
{
  public string? FirstName { get; private set; }
  public string? LastName { get; private set; }

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
}
