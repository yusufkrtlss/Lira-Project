using AutoMapper;
using BusinessLayer.Dto;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AutoMapper
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            // Burada CreateMAp ile hangisini hangisine dönüştüreceğimizi söyleriz makinaya
            CreateMap<CustomerAddDto, Customer>() // Customer Add Dto --> Costomer  Anlamadığın yer varsa baştan alayım yok anladım teşekkür ederim
                .ForMember(destinationMember: dest => dest.CustomerCreatedTime, memberOptions: opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(destinationMember: dest => dest.CustomerModifiedTime, memberOptions: opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<CustomerUpdateDto, Customer>()
                .ForMember(destinationMember: dest => dest.CustomerModifiedTime, memberOptions: opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Customer, CustomerUpdateDto>();
        }
          
    }
}
