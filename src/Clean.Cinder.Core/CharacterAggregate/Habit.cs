using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Cinder.Core.CharacterAggregate;
public readonly record struct Habit
{
  public readonly string ID { get; }
  public readonly string Name { get; }
}
