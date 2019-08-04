using Klient.DAO.Queries;
using Klient.Model;
using Klient.Model.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.DAO.Handlers.Queries
{
    public class GetKlientByIdQueryHandler : IRequestHandler<GetKlientByIdQuery, KlientEntity>
    {
        private readonly DataContext _dataContext;

        public GetKlientByIdQueryHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<KlientEntity> Handle(GetKlientByIdQuery request, CancellationToken cancellationToken)
        {
            var klientEntity = await _dataContext.Klient
                .Where(klient => klient.Id == request._id)
                .FirstOrDefaultAsync(cancellationToken);

            return klientEntity;
        }

    }
}
