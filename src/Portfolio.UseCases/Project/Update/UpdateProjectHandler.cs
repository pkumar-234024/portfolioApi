
using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.Project.Update;
public class UpdateProjectHandler : ICommandHandler<UpdateProjectCommand, Result<Projects>>
{
  private readonly IRepository<Projects> _projectsRepository;
  private readonly IErrorLogger _errorLogger;
  public UpdateProjectHandler(IRepository<Projects> projectRepository, IErrorLogger errorLogger)
  {
    _errorLogger = errorLogger;
    _projectsRepository = projectRepository;
  }
  public async Task<Result<Projects>> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
  {
    try
    {
      var getProject = await _projectsRepository.GetByIdAsync(request.Id);
      if(getProject == null) {
        return Result.NotFound();
      }
      getProject.ProjectName = request.project.ProjectName;
      getProject.ProjectURL = request.project.ProjectURL;
      getProject.ProjectShortDescription = request.project.ProjectShortDescription;
      getProject.ProjectTitle = request.project.ProjectTitle;
      getProject.ModifiedDate = DateTime.Now;
      getProject.ProjectsType = request.project.ProjectsType;

      await _projectsRepository.UpdateAsync(getProject);
      return Result.Success(getProject);
    }
    catch(Exception ex)
    {
      await _errorLogger.SaveErrotrLogAsync(ex.Message, ex.GetBaseException().Message, ex.StackTrace ?? "", 1, "UpdateProjects");
      return Result.Error(ex.Message);
    }
  }
}
