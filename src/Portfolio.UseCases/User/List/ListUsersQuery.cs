using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.User.List;
public record ListUsersQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<Users>>>;
