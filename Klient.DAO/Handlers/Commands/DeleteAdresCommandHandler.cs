using Klient.DAO.Commands;
using Klient.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.DAO.Handlers.Commands
{
    public class DeleteAdresCommandHandler : IRequestHandler<DeleteAdresCommand>
    {
        private readonly DataContext _dataContext;

        public DeleteAdresCommandHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Unit> Handle(DeleteAdresCommand request, CancellationToken cancellationToken)
        {
            var adresEntity = await _dataContext.Klient.FirstOrDefaultAsync(adres => adres.Id == request.Id, cancellationToken);

            if (adresEntity == null)
            {
                //    throw new EntityNotFoundException();
                throw new Exception("Nie znaleziono encji");
            }

            _dataContext.Klient.Remove(adresEntity);

            await _dataContext.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }




    }
}
