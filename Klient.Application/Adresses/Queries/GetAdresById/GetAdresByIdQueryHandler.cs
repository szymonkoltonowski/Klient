using Klient.DAO;
using Klient.Model.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.Application.Adresses.Queries.GetAdresById
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
