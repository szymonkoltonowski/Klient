using Klient.DAO.Commands;
using Klient.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.DAO.Handlers.Commands
{
    public class DeleteKlientCommandHandler : IRequestHandler<DeleteKlientCommand>
    {
        private readonly DataContext _dataContext;

        public DeleteKlientCommandHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Unit> Handle(DeleteKlientCommand request, CancellationToken cancellationToken)
        {
            var klientEntity = await _dataContext.Klient.FirstOrDefaultAsync(klient => klient.Id == request.Id, cancellationToken);

            if (klientEntity == null)
            {
                //    throw new EntityNotFoundException();
                throw new Exception("Nie znaleziono encji");
            }

            _dataContext.Klient.Remove(klientEntity);

            await _dataContext.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }




    }
}
