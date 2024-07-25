using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.Project.Delete;
public class DeleteProjectHandler : ICommandHandler<DeleteProjectCommand, Result<Projects>>
{
  private readonly IRepository<Projects> _projectsRepository;
  private readonly IErrorLogger _errorLogger;
  public DeleteProjectHandler(IRepository<Projects> projectsRepository, IErrorLogger errorLogger)
  {
    _errorLogger = errorLogger;
    _projectsRepository = projectsRepository;
  }
  public async Task<Result<Projects>> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
  {
    try
    {
      var deleteProject = await _projectsRepository.GetByIdAsync(request.Id);
      if(deleteProject == null)
      {
        return Result.NotFound();
      }
      await _projectsRepository.DeleteAsync(deleteProject);

      return Result.Success();  
    }
    catch (Exception ex)
    {
      await _errorLogger.SaveErrotrLogAsync(ex.Message, ex.GetBaseException().Message, ex.StackTrace ?? "", 1, "DeleteProjects");
      return Result.NotFound();
    }
  }
}
