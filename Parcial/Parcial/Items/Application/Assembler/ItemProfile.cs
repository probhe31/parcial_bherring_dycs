using AutoMapper;
using Parcial.Common.Domain.ValueObject;
using Parcial.Items.Application.Dto;
using Parcial.Items.Domain.Entity;

namespace Parcial.Items.Application.Assembler
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<ItemDto, Item>()
                .ForMember(
                    dest => dest.Cost,
                    opts => opts.MapFrom
                    (
                        src => new Money(src.Price, src.Currency)
                    )
                )
                .ForMember(
                    dest => dest.Level,
                    x => x.MapFrom(src => src.Level.ToString())
                );          
        }
    }
}
