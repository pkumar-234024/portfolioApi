using Ardalis.Result;
using FastEndpoints;
using MediatR;
using Portfolio.Core.Modal;
using Portfolio.UseCases.User.Get;
using Portfolio.Web.Endpoints.UserEndPoints;

namespace Portfolio.Web.UserEndPoints;

public class GetById : Endpoint<GetUserByIdRequest, Users>
{
  public readonly IMediator _mediator;

  public GetById(IMediator mediator)
  {
    _mediator = mediator;
  }
  public override void Configure()
  {
    Get("/Users/{Id}");
    AllowAnonymous();
  }

  public override async Task HandleAsync(GetUserByIdRequest request, CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new GetUsersQuery(request.Id));

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }

    if (result.IsSuccess)
    {
      Response = result.Value;
    }
  }
}
