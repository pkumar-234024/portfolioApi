using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Interfaces;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.Project.Create;
public class CreateProjectHandler : ICommandHandler<CreateProjectCommand, Result<Projects>>
{
  private readonly IRepository<Projects> _projectRepository;
  private readonly IErrorLogger _errorLogger;
  public CreateProjectHandler(IRepository<Projects> projectRepository, IErrorLogger errorLogger)
  {
    _errorLogger = errorLogger; 
    _projectRepository = projectRepository;
  }

  public async Task<Result<Projects>> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
  {
    try
    {
      var newProjetcs = request.project;
      newProjetcs.CreatedDate = DateTime.Now;
      var newEntity = await _projectRepository.AddAsync(newProjetcs, cancellationToken);
      return newEntity;

    }
    catch (Exception ex)
    {
      await _errorLogger.SaveErrotrLogAsync(ex.Message, ex.GetBaseException().Message, ex.StackTrace ?? "", 1, "CreateProjets");
      return Result.Error(ex.Message);
    }
  }
}
