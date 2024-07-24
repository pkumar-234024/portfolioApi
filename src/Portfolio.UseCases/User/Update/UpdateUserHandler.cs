using Ardalis.Result;
using Ardalis.SharedKernel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.User.Update;
public class UpdateUserHandler : ICommandHandler<UpdateUserCommand, Result<Users>>
{
  private readonly IRepository<Users> _userRepository;
  private readonly IErrorLogger _errorLogger;
  public UpdateUserHandler(IRepository<Users> userRepository, IErrorLogger errorLogger)
  {
    _errorLogger = errorLogger;
    _userRepository = userRepository;
  }
  public async Task<Result<Users>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
  {
    try
    {
      var entity = await _userRepository.GetByIdAsync(request.Id);
      if (entity == null)
      {
        return Result.NotFound();
      }
      entity.FirstName = request.user.FirstName;
      entity.LastName = request.user.LastName;
      entity.Email = request.user.Email;  
      entity.Password = request.user.Password;
      entity.City = request.user.City;
      entity.Country = request.user.Country;
      entity.ContactNumber = request.user.ContactNumber;
      entity.About = request.user.About;
      entity.ModifiedDate = request.user.ModifiedDate;
      await _userRepository.UpdateAsync(entity);

      return Result.Success(entity);
    }
    catch (Exception ex)
    {
      await _errorLogger.SaveErrotrLogAsync(ex.Message, ex.GetBaseException().Message, ex.StackTrace ?? "", 1, "updateUsers");
      return Result.Error("Error");
    }
  }
}
