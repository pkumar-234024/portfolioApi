using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.User.Delete;
public class DeleteUserHandler : ICommandHandler<DeleteUserCommand, Result>
{
  private readonly IRepository<Users> _usersRepository;
  private readonly IErrorLogger _errorLogger;
  public DeleteUserHandler(IRepository<Users> userRepository,IErrorLogger errorLogger)
  {
    _usersRepository = userRepository;
    _errorLogger = errorLogger;
  }
  public async Task<Result> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
  {
    try
    {
      var entity = await _usersRepository.GetByIdAsync(request.Id);
      if (entity == null)
      {
        return Result.NotFound();
      }
      await _usersRepository.DeleteAsync(entity); 
      return Result.SuccessWithMessage($"User Id {request.Id} has been deleted.");
    }
    catch(Exception ex)
    {
      await _errorLogger.SaveErrotrLogAsync(ex.Message, ex.GetBaseException().Message, ex.StackTrace ?? "", 1, "de;eteUser");
      return Result.Error();
    }
  }
}
