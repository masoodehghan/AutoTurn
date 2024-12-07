using AutoTurn.Application.Offices.Queries.ListForeignQuery;
using AutoTurn.Application.Offices.Queries.ListOfficeQuery;
using AutoTurn.Application.Plans.Commands;
using AutoTurn.Application.Turns.Queries.ListTurnsQuery;
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
            config.NewConfig<User, AdminResponse>();
            config.NewConfig<Turn, TurnResponse>();

            config.NewConfig<(PaginationRequest, int?), ListOfficeQuery>()
                .Map(dest => dest.PageRequest, src => src)
                .Map(dest => dest.ProvinceId, src => src.Item2);

            config.NewConfig<User, UserResponse>();

            config.NewConfig<PaginationRequest, ListForeignQuery>();

            config.NewConfig<ListTurnRequest, ListTurnsQuery>();

            config.NewConfig<Province, ProvinceResponse>();
            config.NewConfig<PlanCommand, Plan>();
        }
    }
}
