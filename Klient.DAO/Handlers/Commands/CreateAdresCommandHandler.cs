using Klient.DAO.Commands;
using Klient.Model;
using Klient.Model.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.DAO.Handlers.Commands
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
                Id = request.Id,
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
