using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Clean.Cinder.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
