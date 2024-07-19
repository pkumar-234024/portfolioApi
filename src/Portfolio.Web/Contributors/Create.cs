using Ardalis.SharedKernel;
using FastEndpoints;
using Portfolio.Web.Endpoints.ContributorEndpoints;
using Portfolio.UseCases.Contributors.List;
using Portfolio.UseCases.Contributors.Create;
using MediatR;
using Portfolio.Core.Modal;

namespace Portfolio.Web.ContributorEndpoints;

public class Create : Endpoint<CreateContributorRequest, CreateContributorResponse>
{
  
  private readonly IMediator _mediator;

  public Create(IRepository<Contributor> repository,
    IMediator mediator)
  {
    _mediator = mediator;
  }

  public override void Configure()
  {
    Post(CreateContributorRequest.Route);
    AllowAnonymous();
    Summary(s =>
    {
      s.ExampleRequest = new CreateContributorRequest { Name = "Contributor Name" };
    });
  }

  public override async Task HandleAsync(
    CreateContributorRequest request,
    CancellationToken ct)
  {
    var result = await _mediator.Send(new CreateContributorCommand(request.Name!));

    if(result.IsSuccess)
    {
      Response = new CreateContributorResponse(result.Value, request.Name!);
      return;
    }
    
  }
}
