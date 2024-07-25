using Ardalis.Result;
using Ardalis.SharedKernel;
using FastEndpoints;
using MediatR;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;
using Portfolio.UseCases.Project.Delete;
using Portfolio.Web.EndPoints.ProjectEndPoints;

namespace Portfolio.Web.Project;

public class Delete : Endpoint<DeleteProjectRequest, Projects>
{

  private readonly IMediator _mediator;
  private readonly IErrorLogger _errorLogger;
  public Delete(IMediator mediator, IErrorLogger errorLogger)
  {
    _errorLogger = errorLogger;
    _mediator = mediator;
  }

  public override void Configure()
  {
    Delete("/Projects/{Id}");
    AllowAnonymous();
  }

  public override async Task HandleAsync(DeleteProjectRequest request, CancellationToken cancellationToken)
  {
    var result = await _mediator.Send(new DeleteProjectCommand(request.Id));
    if (result.IsSuccess)
    {
      await SendNoContentAsync();
      return;
    }
    await SendNotFoundAsync();
  }
}
