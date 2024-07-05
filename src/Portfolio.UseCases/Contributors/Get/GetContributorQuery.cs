using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Portfolio.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
