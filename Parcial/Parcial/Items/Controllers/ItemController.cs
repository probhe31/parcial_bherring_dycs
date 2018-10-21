using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parcial.Common.Application;
using Parcial.Common.Application.Dto;
using Parcial.Common.Domain.Specification;
using Parcial.Items.Application.Assembler;
using Parcial.Items.Application.Dto;
using Parcial.Items.Domain.Entity;
using Parcial.Items.Domain.Repository;
using Parcial.Items.Infraestructure.Persistence.NHibernate.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Items.Controllers
{
    [Route("v1/items")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IItemRepository _itemRepository;
        private readonly ItemAssembler _itemAssembler;

        public ItemController(IUnitOfWork unitOfWork, IItemRepository itemRepository, ItemAssembler itemAssembler)
        {
            _unitOfWork = unitOfWork;
            _itemRepository = itemRepository;
            _itemAssembler = itemAssembler;
        }

        [HttpGet]
        public IActionResult Items([FromQuery]bool legendayItemsOnly)
        {
            bool uowStatus = false;
            
            try
            {
                Specification<Item> specification = GetItemSpecification(legendayItemsOnly);
                uowStatus = _unitOfWork.BeginTransaction();
                List<Item> items = _itemRepository.GetList(specification);
                _unitOfWork.Commit(uowStatus);
                List<ItemDto> itemsDto = _itemAssembler.toDtoList(items);
                return StatusCode(StatusCodes.Status200OK, itemsDto);
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback(uowStatus);
                Console.WriteLine(ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiStringResponseDto("Internal Server Error"));
            }
        }

        private Specification<Item> GetItemSpecification(bool legendayItemsOnly)
        {
            Specification<Item> specification = Specification<Item>.All;

            if (legendayItemsOnly)
                specification = specification.And(new LegendaryItemsSpecification());
            
            return specification;
        }


        //NULL OBJECT PATTERN
        public IItem GetProductById(int itemId)
        {
            Item item= _itemRepository.GetItemById(itemId);
            if (item == null)
                return new NullItem();
            return item;
        }

    }
}
