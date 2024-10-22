﻿using Ardalis.SharedKernel;
using FastEndpoints;
using Portfolio.Web.Endpoints.ContributorEndpoints;
using Portfolio.UseCases.Contributors.Create;
using Portfolio.UseCases.Contributors.Update;
using MediatR;
using Ardalis.Result;
using Portfolio.Core.Modal;

namespace Portfolio.Web.ContributorEndpoints;

/// <summary>
/// Update an existing Contributor.
/// </summary>
/// <remarks>
/// Update an existing Contributor by providing a fully defined replacement set of values.
/// See: https://stackoverflow.com/questions/60761955/rest-update-best-practice-put-collection-id-without-id-in-body-vs-put-collecti
/// </remarks>
public class Update : Endpoint<UpdateContributorRequest, UpdateContributorResponse>
{
  private readonly IRepository<Contributor> _repository;
  private readonly IMediator _mediator;

  public Update(IRepository<Contributor> repository, IMediator mediator)
  {
    _repository = repository;
    _mediator = mediator;
  }

  public override void Configure()
  {
    Put(UpdateContributorRequest.Route);
    AllowAnonymous();
  }

  public override async Task HandleAsync(
    UpdateContributorRequest request,
    CancellationToken ct)
  {
    var result = await _mediator.Send(new UpdateContributorCommand(request.Id, request.Name!));

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(ct);
      return;
    }

    
    var existingContributor = await _repository.GetByIdAsync(request.Id, ct);
    if (existingContributor == null)
    {
      await SendNotFoundAsync(ct);
      return;
    }

    if (result.IsSuccess)
    {
      var dto = result.Value;
      Response = new UpdateContributorResponse(new ContributorRecord(dto.Id, dto.Name));
      return;
    }

  }
}
