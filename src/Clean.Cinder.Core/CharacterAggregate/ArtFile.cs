using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.SharedKernel;

namespace Clean.Cinder.Core.CharacterAggregate;
public class ArtFile : EntityBase<Guid>, IAggregateRoot
{
  public required string ArtType { get; set; }

  public required string Version { get; set; }

  public string? URI { get; set; }

  public string? BlobID { get; set; }

  public string? FileName { get; set; }

  public string? FileExtension { get; set; }

  public required Character Creature { get; set; }
}
