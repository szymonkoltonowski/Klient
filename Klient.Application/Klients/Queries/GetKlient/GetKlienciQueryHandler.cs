using AutoMapper;
using Klient.DAO;
using Klient.Model.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.Application.Klients.Queries.GetKlient
{
    public class GetKlienciQueryHandler : IRequestHandler<GetKlienciQuery, IEnumerable<KlientEntity>>
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public GetKlienciQueryHandler(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<KlientEntity>> Handle(GetKlienciQuery request, CancellationToken cancellationToken)
        {

            var klientEntityList = await _dataContext.Klient.ToListAsync(cancellationToken);

            return klientEntityList;
        }


    }
}
