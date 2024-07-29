using Ardalis.Result;
using FastEndpoints;
using MediatR;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;
using Portfolio.UseCases.Project.Get;
using Portfolio.Web.EndPoints.ProjectEndPoints;

namespace Portfolio.Web.ProjectEndPoints;

public class GetById : Endpoint<GetProjectByIdRequest, Projects>
{
  private readonly IMediator _mediator;
  private readonly IErrorLogger _errorLogger;
  public GetById(IMediator mediator, IErrorLogger errorLogger)
  {
    _errorLogger = errorLogger; 
    _mediator = mediator;

  }

  public override void Configure()
  {
    Get("/Projects/{Id}");
    AllowAnonymous();
  }

  public override async Task HandleAsync(GetProjectByIdRequest request, CancellationToken cancellationToken)
  {
    try
    {
      var result = await _mediator.Send(new GetProjectQuery(request.Id));
      if(result.Status == ResultStatus.NotFound)
      {
        await SendNotFoundAsync();
      }
      Response = result.Value;
    }
    catch(Exception ex) {
      await _errorLogger.SaveErrotrLogAsync(ex.Message, ex.GetBaseException().Message, ex.StackTrace ?? "", 1, "GetByIdController");
      await SendNotFoundAsync();
    }
  }
}
