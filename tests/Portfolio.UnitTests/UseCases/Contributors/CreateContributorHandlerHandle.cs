using Ardalis.SharedKernel;
using Portfolio.UseCases.Contributors.Create;
using FluentAssertions;
using NSubstitute;
using Xunit;
using Portfolio.Core.Modal;

namespace Portfolio.UnitTests.UseCases.Contributors;

public class CreateContributorHandlerHandle
{
  private readonly string _testName = "test name";
  private readonly IRepository<Contributor> _repository = Substitute.For<IRepository<Contributor>>();
  private CreateContributorHandler _handler;

  public CreateContributorHandlerHandle()
  {
      _handler = new CreateContributorHandler(_repository);
  }

  private Contributor CreateContributor()
  {
    return new Contributor(_testName);
  }

  [Fact]
  public async Task ReturnsSuccessGivenValidName()
  {
    _repository.AddAsync(Arg.Any<Contributor>(), Arg.Any<CancellationToken>())
      .Returns(Task.FromResult(CreateContributor()));
    var result = await _handler.Handle(new CreateContributorCommand(_testName), CancellationToken.None);

    result.IsSuccess.Should().BeTrue();    
  }
}
