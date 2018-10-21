using AutoMapper;
using Parcial.Items.Application.Dto;
using Parcial.Items.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Items.Application.Assembler
{
    public class ItemAssembler
    {
        private readonly IMapper _mapper;

        public ItemAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<ItemDto> toDtoList(List<Item> itemList)
        {
            return _mapper.Map<List<Item>, List<ItemDto>>(itemList);
        }

    }
}
