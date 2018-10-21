using Parcial.Common.Application.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Items.Application.Dto
{
    public class ItemDto
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public virtual string Level { get; set; }
        public Decimal Price { get; set; }
        public Currency Currency { get; set; }
    }
}
