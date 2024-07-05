using Ardalis.GuardClauses;
using Ardalis.SharedKernel;
using Portfolio.Core.ContributorAggregate;

namespace Portfolio.Core.Modal;

public class Contributor : EntityBase, IAggregateRoot
{
  public string Name { get; private set; }
  public ContributorStatus Status { get; private set; } = ContributorStatus.NotSet;

  public Contributor(string name)
  {
    Name = Guard.Against.NullOrEmpty(name, nameof(name));
  }

  public void UpdateName(string newName)
  {
    Name = Guard.Against.NullOrEmpty(newName, nameof(newName));
  }
}
