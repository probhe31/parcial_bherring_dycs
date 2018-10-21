using Parcial.Common.Domain.ValueObject;
using Parcial.Items.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Items.Domain.Entity
{
    public interface IItem
    {
        long Id { get; }
        string Name { get; }
        string Description { get; }
        Level Level { get; }
        Money Cost { get; set; }
    }
}
