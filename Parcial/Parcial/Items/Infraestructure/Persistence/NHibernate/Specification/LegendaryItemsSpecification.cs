using Parcial.Common.Domain.Specification;
using Parcial.Items.Domain.Entity;
using System;
using System.Linq.Expressions;

namespace Parcial.Items.Infraestructure.Persistence.NHibernate.Specification
{
    public class LegendaryItemsSpecification : Specification<Item>    
    {
        public override Expression<Func<Item, bool>> ToExpression()
        {
            return item => item.Level == Domain.Enum.Level.LEGENDARY;
        }
    }
}
