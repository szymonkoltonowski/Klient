﻿using Klient.DAO.Queries;
using Klient.Model;
using Klient.Model.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.DAO.Handlers.Queries
{
    public class GetAdresQueryHandler : IRequestHandler<GetAdresQuery, IEnumerable<AdresEntity>>
    {
        private readonly DataContext _dataContext;

        public GetAdresQueryHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<AdresEntity>> Handle(GetAdresQuery request, CancellationToken cancellationToken)
        {
            var adresEntityList = await _dataContext.Adres.ToListAsync(cancellationToken);

            return adresEntityList;
        }
    }
}
