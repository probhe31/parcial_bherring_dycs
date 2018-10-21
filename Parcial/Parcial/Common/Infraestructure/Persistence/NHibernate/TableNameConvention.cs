using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using Parcial.Common.Application;

namespace Parcial.Common.Infraestructure.Persistence.NHibernate
{
    public class TableNameConvention : IClassConvention
    {
        public void Apply(IClassInstance instance)
        {
            instance.Table(Util.getTableName(instance.EntityType.Name));
        }
    }
}
