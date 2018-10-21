using Parcial.Common.Domain.Specification;
using Parcial.Common.Infraestructure.Persistence.NHibernate;
using Parcial.Items.Domain.Entity;
using Parcial.Items.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Items.Infraestructure.Persistence.NHibernate.Repository
{
    public class ItemNHibernateRepository : BaseNHibernateRepository<Item>, IItemRepository
    {
        public ItemNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {
        }

        

        public List<Item> GetList(Specification<Item> specification, int page = 0, int pageSize = 5)
        {
            List<Item> items = new List<Item>();
            bool uowStatus = false;
            try
            {
                uowStatus = _unitOfWork.BeginTransaction();
                items = _unitOfWork.GetSession().Query<Item>()
                    .Where(specification.ToExpression())                    
                    .Skip(page * pageSize)
                    .Take(pageSize)                    
                    .ToList();
                _unitOfWork.Commit(uowStatus);
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback(uowStatus);
                throw ex;
            }
            return items;
        }


        
        public Item GetItemById(long id)
        {
            throw new NotImplementedException();
        }


    }
}
