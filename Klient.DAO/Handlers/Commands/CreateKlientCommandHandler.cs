using Klient.DAO.Commands;
using Klient.Model;
using Klient.Model.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.DAO.Handlers.Commands
{
    public class CreateKlientCommandHandler : IRequestHandler<CreateKlientCommand>
    {
        private readonly DataContext _dataContext;

        public CreateKlientCommandHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Unit> Handle(CreateKlientCommand request, CancellationToken cancellationToken)
        {
            var klientEntity = new KlientEntity
            {
                Id = request.Model.Id,
                Pesel = request.Model.Pesel,
                Imie = request.Model.Imie,
                Nazwisko = request.Model.Nazwisko,
                AdresId = request.Model.AdresId
            };

            _dataContext.Klient.Add(klientEntity);

            await _dataContext.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }

    }
}
