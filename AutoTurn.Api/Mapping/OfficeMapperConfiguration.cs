using AutoTurn.Contracts;
using AutoTurn.Models;
using Mapster;

namespace AutoTurn.Api.Mapping
{
    public class OfficeMapperConfiguration : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Office, OfficeResponse>();
            config.NewConfig<Province, ProvinceResponse>();
        }
    }
}
