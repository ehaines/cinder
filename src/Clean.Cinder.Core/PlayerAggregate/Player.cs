using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace Clean.Cinder.Core.PlayerAggregate;
public class Player : EntityBase<Guid>, IAggregateRoot
{
  public required string UserName { get; set; }
  public required string Email { get; set; }
  public string? WalletAddress { get; set; }
  public int RemainingMatchOptions { get; set; }
  public int RemainingLikes { get; set; }
  public int RemainingSuperLikes { get; set; }
  public int RemainingLLMTokens { get; set; }
  public DateTimeOffset? AdFreePeriodStartedOn { get; set; }


}
