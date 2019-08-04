using Klient.DAO.Queries;
using Klient.Model;
using Klient.Model.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.DAO.Handlers.Queries
{
    public class GetAdresByIdQueryHandler : IRequestHandler<GetAdresByIdQuery,AdresEntity>
    {
        private readonly DataContext _dataContext;

        public GetAdresByIdQueryHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerator<AdresEntity> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

   
        public async Task<AdresEntity> Handle(GetAdresByIdQuery request, CancellationToken cancellationToken)
        {
            var adresEntity = await _dataContext.Adres
                   .Where(adres => adres.Id == request._id)
                   .FirstOrDefaultAsync(cancellationToken);

            return adresEntity;
        }
    }
}
