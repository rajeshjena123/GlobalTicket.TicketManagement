﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Quries.GetCategoryList
{
    public class GetCategoriesListQuery: IRequest<List<CategoryListVm>>
    {
    }
}
