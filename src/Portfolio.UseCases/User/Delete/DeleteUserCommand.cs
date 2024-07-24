using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Portfolio.UseCases.User.Delete;
public record DeleteUserCommand(int Id) : ICommand<Result>;
