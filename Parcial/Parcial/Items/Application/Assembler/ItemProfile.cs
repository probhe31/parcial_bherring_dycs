using AutoMapper;
using Parcial.Items.Application.Dto;
using Parcial.Items.Domain.Entity;

namespace Parcial.Items.Application.Assembler
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, ItemDto>().ForMember(
                dest=>dest.Level, 
                x=> x.MapFrom(src =>src.Level.ToString())
                );
        }
    }
}
