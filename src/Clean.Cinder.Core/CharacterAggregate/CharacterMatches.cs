using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Cinder.Core.CharacterAggregate;
public class CharacterMatches
{
  public Guid CharacterID { get; set; }
  public required Character Character {  get; set; }

  public Guid SuitorID { get; set; }
  public required Character Suitor { get; set; }

  public bool Liked { get; set; }
  public DateTimeOffset LikedRejectedOn { get; set; }

  public bool Matched { get; set; }
  public DateTimeOffset? MatchedOn { get; set; }

  public bool SuperLiked { get; set; }
  public DateTimeOffset? SuperLikedOn { get; set; }

  public bool Proposed { get; set; }
  public DateTimeOffset? ProposedOn { get; set; }

  public bool Partnered { get; set; }
  public DateTimeOffset? PartneredOn { get; set; }

}
