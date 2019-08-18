using Klient.Core.Exceptions;
using Klient.DAO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.Application.Adresses.Commands.UpdateAdres
{
    public class UpdateAdresCommandHandler : IRequestHandler<UpdateAdresCommand>
    {
        private readonly DataContext _dataContext;

        public UpdateAdresCommandHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Unit> Handle(UpdateAdresCommand request, CancellationToken cancellationToken)
        {
            var adresEntity = await _dataContext.Adres.FirstOrDefaultAsync(adres => adres.Id == request.Id, cancellationToken);

            if (adresEntity == null)
            {
                throw new EntityNotFoundException();
            }
            adresEntity.Ulica = request.Ulica;
            adresEntity.NrMieszkania = request.NrMieszkania;
            adresEntity.NrDomu = request.NrDomu;
            adresEntity.Miasto = request.Miasto;


            await _dataContext.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }


    }
}
