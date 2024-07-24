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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
      var createdItem = await _users.AddAsync(newUser, cancellationToken);
      return createdItem;
    }
    catch (Exception ex)
    {
      await _errorLogger.SaveErrotrLogAsync(ex.Message, ex.GetBaseException().Message, ex.StackTrace??"trace", 1, "createUser");
      return new Users{ Email="", FirstName="", LastName=""};
      
    }    
  }
}
