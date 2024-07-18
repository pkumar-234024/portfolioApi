using FastEndpoints;
using MediatR;
using Portfolio.UseCases.User.List;
using Portfolio.Web.EndPoints.UserEndPoints;

namespace Portfolio.Web.UserEndPoints;

public class List : EndpointWithoutRequest<UsersListResponse>
{
  private readonly IMediator _mediator;

  public List(IMediator mediator)
  {
    _mediator = mediator;
  }


  public override void Configure()
  {
    Get("/Users");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new ListUsersQuery(null, null));
    if(result.IsSuccess)
    {
      Response = new UsersListResponse
      {
        Users = result.Value.ToList()
      };
    }
  }
}
