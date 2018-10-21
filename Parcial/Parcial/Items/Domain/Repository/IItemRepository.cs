using Parcial.Common.Domain.Specification;
using Parcial.Items.Domain.Entity;
using System.Collections.Generic;

namespace Parcial.Items.Domain.Repository
{
    public interface IItemRepository
    {
      
        List<Item> GetList(
            Specification<Item> specification,
            int page = 0,
            int pageSize = 5);

        Item GetItemById(long id);
    }
}
