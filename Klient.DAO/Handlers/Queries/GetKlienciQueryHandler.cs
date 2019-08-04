using Klient.DAO.Queries;
using Klient.Model;
using Klient.Model.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.DAO.Handlers.Queries
{
    public class GetKlienciQueryHandler : IRequestHandler<GetKlienciQuery, IEnumerable<KlientEntity>>
    {
        private readonly DataContext _dataContext;

        public GetKlienciQueryHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<KlientEntity>> Handle(GetKlienciQuery request, CancellationToken cancellationToken)
        {
            var klientEntityList = await _dataContext.Klient.ToListAsync(cancellationToken);

            return klientEntityList;
        }


    }
}
