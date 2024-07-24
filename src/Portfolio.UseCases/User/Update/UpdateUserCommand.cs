using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.User.Update;
public record UpdateUserCommand(int Id, Users user) : ICommand<Result<Users>>;
