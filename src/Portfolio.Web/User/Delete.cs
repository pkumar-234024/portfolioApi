
using Ardalis.Result;
using FastEndpoints;
using MediatR;
using Portfolio.UseCases.User.Delete;
using Portfolio.Web.EndPoints.UserEndPoints;

namespace Portfolio.Web.UserEndPoints;

public class Delete : Endpoint<DeleteUserRequest>
{
  private readonly IMediator _mediator;
  public Delete(IMediator mediator)
  {
    _mediator = mediator;
  }
  public override void Configure()
  {
    Delete("/Users/{Id}");
    AllowAnonymous();
  }
  public override async Task HandleAsync(DeleteUserRequest request, CancellationToken cancellationToken)
  {
    //var command = new DeleteUserCommand(request.Id);
    var result = await _mediator.Send(new DeleteUserCommand(request.Id));

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }

    if (result.IsSuccess)
    {
      await SendNoContentAsync(cancellationToken);
    }
  }
}
