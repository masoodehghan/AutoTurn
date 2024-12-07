using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTurn.Application.Authentication.Queries;

public class ListUsersQueryHandler : IRequestHandler<ListUsersQuery, List<User>>
{
    private readonly IUserRepository _userRepository;

    public ListUsersQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<User>> Handle(ListUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.
            GetUserListAsync(
            request.PageRequest?.PageSize ?? 10,
            request.PageRequest?.PageIndex ?? 0);

        return new List<User>(users);
    }
}
