using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.Project.Get;
public class GetProjectHandler : IQueryHandler<GetProjectQuery, Result<Projects>>
{
  private readonly IRepository<Projects> _projectsRepository;
  private readonly IErrorLogger _errorLogger;
  public GetProjectHandler(IRepository<Projects> projectRepository, IErrorLogger errorLogger)
  {
    _errorLogger = errorLogger;
    _projectsRepository = projectRepository;
  }
  public async Task<Result<Projects>> Handle(GetProjectQuery request, CancellationToken cancellationToken)
  {
    try
    {
      var getProject = await _projectsRepository.GetByIdAsync(request.Id);
      if(getProject == null)
      {
        return Result.NotFound();
      }
      return getProject;
    }
    catch (Exception ex)
    {
      await _errorLogger.SaveErrotrLogAsync(ex.Message, ex.GetBaseException().Message, ex.StackTrace ?? "", 1, "GetProject");
      return Result.Error(ex.Message);
    }
  }
}
