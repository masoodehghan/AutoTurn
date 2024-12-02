using AutoTurn.Application.Plans.Commands;
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
            config.NewConfig<PlanSetting, PlanSettingResponse>();

            config.NewConfig<Province, ProvinceResponse>();
            config.NewConfig<PlanCommand, Plan>();
        }
    }
}
