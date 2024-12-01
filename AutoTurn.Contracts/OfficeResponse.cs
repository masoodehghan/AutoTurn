using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTurn.Contracts;

public record OfficeResponse(
    int Id,
    string Name,
    ProvinceResponse Province,
    List<PlanSettingResponse> PlanSetting,
    AddressResponse Address
    );



public record PlanSettingResponse(
    string? PlanStartTime,
    string? PlanEndTime,
    int? PlanCapacity
    );

public record AddressResponse(
    string City,
    string Province,
    string Street,
    string PostalCode
    );

