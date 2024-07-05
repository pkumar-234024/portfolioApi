using Portfolio.Core.ContributorAggregate;
using Portfolio.Core.Modal;
using Xunit;

namespace Portfolio.IntegrationTests.Data;

public class EfRepositoryAdd : BaseEfRepoTestFixture
{
  [Fact]
  public async Task AddsContributorAndSetsId()
  {
    var testContributorName = "testContributor";
    var testContributorStatus = ContributorStatus.NotSet;
    var repository = GetRepository();
    var Contributor = new Contributor(testContributorName);

    await repository.AddAsync(Contributor);

    var newContributor = (await repository.ListAsync())
                    .FirstOrDefault();

    Assert.Equal(testContributorName, newContributor?.Name);
    Assert.Equal(testContributorStatus, newContributor?.Status);
    Assert.True(newContributor?.Id > 0);
  }
}
