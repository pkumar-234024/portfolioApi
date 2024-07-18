using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.User.List;
public class ListUsersHandler : IQueryHandler<ListUsersQuery, Result<IEnumerable<Users>>>
{
  private readonly IRepository<Users> _users;
  public ListUsersHandler(IRepository<Users> users)
  {
    _users = users;
  }

  public async Task<Result<IEnumerable<Users>>> Handle(ListUsersQuery request,CancellationToken cancellationToken)
  {
    var result = await _users.ListAsync();
    return Result.Success((IEnumerable<Users>)result);

  }
}
