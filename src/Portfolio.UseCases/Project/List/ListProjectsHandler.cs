using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.Project.List;
public class ListProjectsHandler : IQueryHandler<ListProjectsQuery, Result<IEnumerable<Projects>>>
{
  private readonly IRepository<Projects> _projectsRepository;
  public ListProjectsHandler(IRepository<Projects> projectsRepository)
  {
    _projectsRepository = projectsRepository;
  }

  public async Task<Result<IEnumerable<Projects>>> Handle(ListProjectsQuery request, CancellationToken cancellationToken)
  {
    var result = await _projectsRepository.ListAsync();
    return Result.Success((IEnumerable<Projects>)result);
  }
}
