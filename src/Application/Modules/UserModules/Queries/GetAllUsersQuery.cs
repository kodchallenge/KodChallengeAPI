using AutoMapper;
using Kod.Application.Abstractions.Services;
using Kod.Core.Domain.Abstractions;
using Kod.Core.Domain.Models;
using MediatR;

namespace Kod.Application.Modules.UserModules.Queries
{
    public record GetAllUsersQuery(IPaginateRequest Request) : IRequest<Paginate<GetAllUsersQueryResponse>>;

    public record GetAllUsersQueryResponse(int Id, string FullName, string Username);

    public record GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, Paginate<GetAllUsersQueryResponse>>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public GetAllUsersQueryHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<Paginate<GetAllUsersQueryResponse>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var list = await _userService.GetListWithPaginate(request.Request);

            return list.ConvertItems(x => _mapper.Map<GetAllUsersQueryResponse>(x));
        }
    }
}
