﻿using Parcial.Common.Domain.ValueObject;
using Parcial.Items.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Items.Domain.Entity
{
    public class Item : IItem
    {
        public virtual long Id { get; protected set; }
        public virtual string Name { get; }
        public virtual string Description { get; }
        public virtual Level Level { get; }
        public virtual Money Cost { get; set; }
        

        public Item()
        {
        }
    }
}
