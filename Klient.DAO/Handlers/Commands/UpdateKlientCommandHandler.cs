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
    public class UpdateKlientCommandHandler : IRequestHandler<UpdateKlientCommand>
    {
        private readonly DataContext _dataContext;

        public UpdateKlientCommandHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Unit> Handle(UpdateKlientCommand request, CancellationToken cancellationToken)
        {
            var klientEntity = await _dataContext.Klient.FirstOrDefaultAsync(klient => klient.Id == request.Model.Id, cancellationToken);

             if (klientEntity == null)
             {
                //    throw new EntityNotFoundException();
                throw new Exception("Nie znaleziono encji");
            }

            klientEntity.Imie = request.Model.Imie;
            klientEntity.Nazwisko = request.Model.Nazwisko;
            klientEntity.Pesel = request.Model.Pesel;

            await _dataContext.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }


    }
}
