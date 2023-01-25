using AutoMapper;
using BankBrasilApi.Dtos;
using BankBrasilApi.models;

namespace BankBrasilApi.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
        
    }
}
