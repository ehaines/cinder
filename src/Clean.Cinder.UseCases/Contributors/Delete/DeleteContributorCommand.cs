using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Clean.Cinder.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
