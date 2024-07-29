using Ardalis.Result;
using FastEndpoints;
using MediatR;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;
using Portfolio.UseCases.Project.Update;
using Portfolio.Web.EndPoints.ProjectEndPoints;

namespace Portfolio.Web.Project;

public class Update :Endpoint<UpdateProjectRequest, Projects>
{
  private readonly IMediator _mediator;
  private readonly IErrorLogger _errorLogger;

  public Update(IMediator mediator, IErrorLogger errorLogger)
  {
    _errorLogger = errorLogger;
    _mediator = mediator; 
  }
  public override void Configure()
  {
    Put("/Projects/{Id}");
    AllowAnonymous();
  }

  public override async Task HandleAsync(UpdateProjectRequest request, CancellationToken cancellationToken)
  {
    try
    {
      var result = await _mediator.Send(new  UpdateProjectCommand(request.Id, request.project));
      if(result.Status == ResultStatus.NotFound)
      {
        await SendNoContentAsync();
      }
      Response = result.Value;

    }
    catch(Exception ex)
    {
     Console.WriteLine(ex.ToString());
      await SendNotFoundAsync();

    }
  }
}
