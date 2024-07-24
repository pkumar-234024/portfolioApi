using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.User.Get;
public record GetUsersQuery(int Id) :IQuery<Result<Users>>;
