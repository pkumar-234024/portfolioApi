using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Portfolio.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
