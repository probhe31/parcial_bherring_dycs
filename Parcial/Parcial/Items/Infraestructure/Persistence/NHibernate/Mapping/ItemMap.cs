using FluentNHibernate.Mapping;
using Parcial.Items.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Items.Infraestructure.Persistence.NHibernate.Mapping
{
    public class ItemMap : ClassMap<Item>
    {
        public ItemMap()
        {
            Id(x => x.Id).Column("item_id");
            Map(x => x.Name).Column("item_name");
            Map(x => x.Description).Column("item_description");            
            Map(x => x.Level).CustomType<int>().Column("item_level");
            Component(x => x.Cost, m =>
            {
                m.Map(x => x.Amount, "cost");
                m.Map(x => x.Currency, "currency");
            });

        }
    }
}
