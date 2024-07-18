using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.Project.List;

public record ListProjectsQuery(int? skip, int? take) : IQuery<Result<IEnumerable<Projects>>>;
