using Klient.DAO;
using Klient.Model.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.Application.Adresses.Commands.CreateAdres
{
    public class CreateAdresCommandHandler : IRequestHandler<CreateAdresCommand>
    {
        private readonly DataContext _dataContext;

        public CreateAdresCommandHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Unit> Handle(CreateAdresCommand request, CancellationToken cancellationToken)
        {
            var adresEntity = new AdresEntity
            {
                Miasto = request.Miasto,
                Ulica = request.Ulica,
                NrDomu = request.NrDomu,
                NrMieszkania = request.NrMieszkania

            };

                _dataContext.Adres.Add(adresEntity);            

            await _dataContext.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }


    }
}
