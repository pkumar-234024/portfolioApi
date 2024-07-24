using Ardalis.Result;
using Ardalis.SharedKernel;
using FastEndpoints;
using MediatR;
using Portfolio.Core.Modal;
using Portfolio.UseCases.User.Update;
using Portfolio.Web.EndPoints.UserEndPoints;

namespace Portfolio.Web.UserEndPoints;

public class Update : Endpoint<UpdateUserRequest, Users>
{
  private readonly IMediator _mediator;
  private readonly IRepository<Users> _repository;
  public Update(IMediator mediator, IRepository<Users> repository)
  {
    _mediator = mediator;
    _repository = repository;
  }

  public override void Configure()
  {
    Put("/Users/{Id}");
    AllowAnonymous();
  }
  public override async Task HandleAsync(UpdateUserRequest request, CancellationToken cancellationToken)
  {
    try
    {
      var result = await _mediator.Send(new UpdateUserCommand(request.Id, request.users));
      if(result.Status == ResultStatus.NotFound)
      {
        await SendNotFoundAsync(cancellationToken);
      }

      if (result.IsSuccess)
      {
        Response = result;
        return;
      }
      //var userById =  await _repository.GetByIdAsync(request.Id);
      //if(userById == null)
      //{
      //  return Result.NotFound();
      //}
      //return Result.Success(userById);


    }
    catch (Exception ex)
    {
      Console.Write(ex.ToString());
      await SendNotFoundAsync(cancellationToken);
      //return Result.NotFound();
    }
  }
}
