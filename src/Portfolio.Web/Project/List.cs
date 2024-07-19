using FastEndpoints;
using MediatR;
using Portfolio.UseCases.Project.List;
using Portfolio.Web.EndPoints.ProjectEndPoints;
using Portfolio.Web.EndPoints.UserEndPoints;

namespace Portfolio.Web.ProjectEndPoints;

public class List : EndpointWithoutRequest<ProjectsListResponse>
{
  private readonly IMediator _mediator;
  public List(IMediator mediator)
  {
    _mediator = mediator;
  }

  public override void Configure()
  {
    Get("/Projects");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CancellationToken ct)
  {
    var result = await _mediator.Send(new ListProjectsQuery(null, null));

    if (result.IsSuccess)
    {
      Response = new ProjectsListResponse
      {
        Projects = result.Value.ToList()
      };
    }
  }
}
