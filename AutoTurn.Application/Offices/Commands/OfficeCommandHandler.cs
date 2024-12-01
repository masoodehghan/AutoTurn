﻿using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using AutoTurn.Models.Enums;
using AutoTurn.Models.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AutoTurn.Application.Offices.Commands;


public class OfficeCommandHandler : IRequestHandler<OfficeCommand, ErrorOr<Office>>
{
    private readonly IOfficeRepository _officeRepository;
    private readonly IUserRepository _userRepository;

    private readonly UserManager<User> _userManager;

    public OfficeCommandHandler(IOfficeRepository officeRepository, UserManager<User> userManager, IUserRepository userRepository)
    {
        _officeRepository = officeRepository;
        _userManager = userManager;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<Office>> Handle(OfficeCommand request, CancellationToken cancellationToken)
    {
        Address address = new Address
        {
            City = request.Address.City,
            Street = request.Address.Street,
            PostalCode = request.Address.PostalCode,
        };

        Office office = new Office
        {
            Id = request.Id,
            Name = request.Name,
            ProvinceId = request.ProvinceId
        };

        office.Address = address;

        try
        {
            await _officeRepository.AddOfficeAsync(office);
        }
        catch (DbUpdateException ex)
        {
            Console.WriteLine(ex);
            return Errors.Office.WrongData;
        }
        return office;
    }
}
