using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;
using Portfolio.UseCases.Contributors.Create;

namespace Portfolio.UseCases.User.Create;
public class CreateUsersHandler : ICommandHandler<CreateUsersCommand, Result<Users>>
{
  private readonly IRepository<Users> _users;
  private readonly IRepository<ErrorLogs> _errorLogs;

  private readonly IErrorLogger _errorLogger;
  public CreateUsersHandler(IRepository<Users> users, IErrorLogger errorLogger, IRepository<ErrorLogs> errorLogs)
  {
    _users = users;
    _errorLogger = errorLogger;
    _errorLogs = errorLogs;
  }

  public async Task<Result<Users>> Handle(CreateUsersCommand request, CancellationToken cancellationToken)
  {
    try
    {
      var newUser = request.users;
      newUser.CreatedDate = DateTime.Now;
      newUser.Email = null;
      var createdItem = await _users.AddAsync(newUser, cancellationToken);
      return createdItem;
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex);
      await _errorLogger.SaveErrotrLogAsync(ex.Message, ex.GetBaseException().Message, ex.StackTrace, 1, "createUser");
      //var newError = new ErrorLogs { ContollerName = "createUser", InnerMessage = ex.GetBaseException().Message.ToString(), Message = ex.Message.ToString(), StackTrace = ex.StackTrace?.ToString(), CreadtedBy = 1, CreatedDate = new DateTime()};
      //await _errorLogs.AddAsync(newError, cancellationToken);
      return new Users{ Email="", FirstName="", LastName=""};
      
    }

    
  }
}
