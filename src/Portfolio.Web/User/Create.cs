using Ardalis.SharedKernel;
using Azure;
using FastEndpoints;
using MediatR;
using Portfolio.Core.Modal;
using Portfolio.UseCases.Contributors.Create;
using Portfolio.UseCases.User.Create;
using Portfolio.Web.Endpoints.ContributorEndpoints;

namespace Portfolio.Web.UserEndPoints;
public class Create : Endpoint<Users, Users>
{

  private readonly IMediator _mediator;

  public Create(IMediator mediator)
  {
    _mediator = mediator;
  }

  public override void Configure()
  {
    Post("/users");
    AllowAnonymous();
    Summary(s =>
    {
      s.ExampleRequest = new Users { FirstName = "First Name", LastName="Last Name", Email="example@gmail.com"};
    });
  }

  public override async Task HandleAsync(
    Users request,
    CancellationToken ct)
  {
    var result = await _mediator.Send(new CreateUsersCommand(request));

    if (result.IsSuccess)
    {
      Response = result;
    }

  }
}
