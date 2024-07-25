using Ardalis.Result;
using Ardalis.SharedKernel;
using Portfolio.Core.Modal;

namespace Portfolio.UseCases.Project.Delete;
public record DeleteProjectCommand(int Id) : ICommand<Result<Projects>>;
