using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.User.Create;
public record CreateUsersCommand(int userId,Users users) : ICommand<Result<Users>>;

