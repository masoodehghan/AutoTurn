using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using AutoTurn.Models.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace AutoTurn.Application.Offices.Queries.ListOfficeQuery;

public class ListOfficeQueryHandler :
            IRequestHandler<ListOfficeQuery, ErrorOr<List<Office>>>
{
    private readonly IOfficeRepository _officeRepository;
    private readonly IUserRepository _userRepository;
    private readonly UserManager<User> _userManager;

    public ListOfficeQueryHandler(
        IOfficeRepository officeRepository,
        IUserRepository userRepository,
        UserManager<User> userManager)
    {
        _officeRepository = officeRepository;
        _userRepository = userRepository;
        _userManager = userManager;
    }

    public async Task<ErrorOr<List<Office>>> Handle(ListOfficeQuery request, CancellationToken cancellationToken)
    {

        int? provinceId = request.ProvinceId;
        if (!request.AuthUser!.IsInRole("SuperAdmin"))
        {
            var userId = _userManager.GetUserId(request.AuthUser);
            var user = await _userRepository.GetUserByIdWithProvinceAsync(userId);

            if (user.Province is null)
            {
                return Errors.Authentication.Forbidden;
            }
            provinceId = user.Province.Id;
        }

        var offices = await _officeRepository.GetAllOfficeAsync(
           provinceId);



        return new List<Office>(offices);
    }
}
