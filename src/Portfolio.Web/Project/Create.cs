using FastEndpoints;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;
using Portfolio.UseCases.Project.Create;

namespace Portfolio.Web.Project;

public class Create : Endpoint<Projects, Projects>
{
  private readonly IMediator _mediator;
  private readonly IErrorLogger _errorLogger;
  public Create(IMediator mediator, IErrorLogger errorLogger)
  {
    _mediator = mediator;
    _errorLogger = errorLogger;
  }
  public override void Configure()
  {
    Post("/Projects");
    AllowAnonymous();
  }

  public override async Task HandleAsync(Projects projects, CancellationToken cancellationToken)
  {
    try
    {
      var result = await _mediator.Send(new CreateProjectCommand(projects));
      if (result.IsSuccess)
      {
        Response = result;
      }
    }
    catch (Exception ex)
    {
      await _errorLogger.SaveErrotrLogAsync(ex.Message, ex.GetBaseException().Message, ex.StackTrace ?? "", 1, "CreateProjects");
    }
    
    
  }
}
