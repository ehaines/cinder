using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace Clean.Cinder.Core;
public class Creature : EntityBase<Guid>, IAggregateRoot
{
  public required string Name { get; set; }
  public string? Description { get; set; }
  public required string SpeciesID { get; set; }
  public required JsonDocument Traits { get; set; }
  public Player? Owner { get; set; }

  public Creature? ParentA { get; set; }
  public Creature? ParentB { get; set; }

  public int Goodness { get; set; }
  public int Lawfulness { get; set; }
  public int Vitality { get; set; }

  public required Attitude Attitude { get; set; }
  public required Appearance Appearance { get; set; }
  public required Habitat Habitat { get; set; }
  public required Habit Habit { get; set; }
  public required Theme Theme { get; set; }
  public required List<ArtFile> ArtFiles { get; set; }

  public DateTimeOffset ToddlerCompletedOn { get; set; }
  public DateTimeOffset MiddleSchoolCompletedOn { get; set; }
  public DateTimeOffset TeenCompletedOn { get; set; }
  public DateTimeOffset? LastModified { get; set; }
  public DateTimeOffset Created { get; set; }

  public DateTimeOffset MintedOn { get; set; }
  public DateTimeOffset MintingChain { get; set; }

  




}
