using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Quries.GetCategoryList
{
    public class GetCategoriesListQueryHandler:IRequestHandler<GetCategoriesListQuery, List<CategoryListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Category> _categoryRepository;
        public GetCategoriesListQueryHandler(IMapper mapper, IAsyncRepository<Category> categoryRepository)
        {
            this._mapper = mapper;
            this._categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryListVm>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var allCategories = (await _categoryRepository.ListAllAsync()).OrderBy(x=>x.Name);
            return _mapper.Map<List<CategoryListVm>>(allCategories);
        }
    }
    
}
