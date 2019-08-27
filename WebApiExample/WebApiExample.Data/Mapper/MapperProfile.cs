using AutoMapper;
using WebApiExample.Domain;

namespace WebApiExample.Data.Mapper
{
    internal class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Entities.Customer, Customer>()
                .ForMember(d => d.CustomerID, opt => opt.MapFrom(s => s.ID));

            CreateMap<Entities.Transaction, Transaction>();
        }
    }
}
