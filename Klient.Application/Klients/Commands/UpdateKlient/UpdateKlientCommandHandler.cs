using Klient.Core.Exceptions;
using Klient.DAO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.Application.Klients.Commands.UpdateKlient
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
            var klientEntity = await _dataContext.Klient.FirstOrDefaultAsync(klient => klient.Id == request.Id, cancellationToken);

             if (klientEntity == null)
             {
                throw new EntityNotFoundException();
            }

            klientEntity.Imie = request.Imie;
            klientEntity.Nazwisko = request.Nazwisko;
            klientEntity.Pesel = request.Pesel;
            klientEntity.AdresId = request.AdresId;
                
            await _dataContext.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }


    }
}
