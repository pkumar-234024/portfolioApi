using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.Project.Update;
public record UpdateProjectCommand(int Id, Projects project) : ICommand<Result<Projects>>;
