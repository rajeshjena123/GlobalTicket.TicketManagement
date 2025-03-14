using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Quries.GetCategpriesListWithEvent
{
    public class GetCategpriesListWithEventQuery : IRequest<List<CategoryEventListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}
