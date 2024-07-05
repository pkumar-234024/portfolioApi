using FastEndpoints;
using Ardalis.Result;
using MediatR;
using Portfolio.Web.Endpoints.ContributorEndpoints;
using Portfolio.UseCases.Contributors.Delete;

namespace Portfolio.Web.ContributorEndpoints;

/// <summary>
/// Delete a Contributor.
/// </summary>
/// <remarks>
/// Delete a Contributor by providing a valid integer id.
/// </remarks>
public class Delete : Endpoint<DeleteContributorRequest>
{
  private readonly IMediator _mediator;

  public Delete(IMediator mediator)
  {
    _mediator = mediator;
  }

  public override void Configure()
  {
    Delete(DeleteContributorRequest.Route);
    AllowAnonymous();
  }

  public override async Task HandleAsync(
    DeleteContributorRequest request,
    CancellationToken cancellationToken)
  {
    var command = new DeleteContributorCommand(request.ContributorId);

    var result = await _mediator.Send(command);

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }

    if (result.IsSuccess)
    {
      await SendNoContentAsync(cancellationToken);
    };
    // TODO: Handle other issues as needed
  }
}
