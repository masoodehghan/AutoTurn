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
    List<PlanSettingResponse> PlanSettings,
    AddressResponse Address
    );



public record PlanSettingResponse(
    string? StartTime,
    string? EndTime,
    int? PlanCapacity
    );

public record AddressResponse(
    string City,
    string Province,
    string Street,
    string PostalCode
    );

