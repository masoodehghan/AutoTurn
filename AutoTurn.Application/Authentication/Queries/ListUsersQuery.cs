using AutoTurn.Contracts;
using AutoTurn.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTurn.Application.Authentication.Queries;

public record ListUsersQuery(
    PaginationRequest? PageRequest
    ) : IRequest<List<User>>;
