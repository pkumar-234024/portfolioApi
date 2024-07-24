using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.User.Get;
public class GetUserHandler : IQueryHandler<GetUsersQuery, Result<Users>>
{
  private readonly IRepository<Users> _usersRepository;

  private readonly IErrorLogger _errorLogger;
  public GetUserHandler(IRepository<Users> usersRepository, IErrorLogger errorLogger)
  {
    _usersRepository = usersRepository;
    _errorLogger = errorLogger;
  }

  public async Task<Result<Users>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
  {
    try
    {
      var entity = await _usersRepository.GetByIdAsync(request.Id);
      if (entity == null) { return Result.NotFound(); }
      return entity;
    }
    catch (Exception ex)
    {
      Console.Write(ex.ToString());
      await _errorLogger.SaveErrotrLogAsync(ex.Message, ex.GetBaseException().Message,ex.StackTrace??"",1,"GetByIdController");
      return Result.NotFound();
    }
  }
}
