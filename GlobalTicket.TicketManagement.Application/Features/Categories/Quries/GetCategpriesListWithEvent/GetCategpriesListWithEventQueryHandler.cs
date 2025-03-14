using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Quries.GetCategpriesListWithEvent
{
    public class GetCategpriesListWithEventQueryHandler : IRequestHandler<GetCategpriesListWithEventQuery, List<CategoryEventListVm>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public GetCategpriesListWithEventQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            this._mapper = mapper;
            this._categoryRepository = categoryRepository;
        }
        public async Task<List<CategoryEventListVm>> Handle(GetCategpriesListWithEventQuery request, CancellationToken cancellationToken)
        {
            var list = await _categoryRepository.GetCategoriesWithEvents(request.IncludeHistory);
            return _mapper.Map<List<CategoryEventListVm>>(list);
        }
    }
}
