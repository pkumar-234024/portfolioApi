using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.Project.Create;
public record CreateProjectCommand(Projects project) : ICommand<Result<Projects>>;
