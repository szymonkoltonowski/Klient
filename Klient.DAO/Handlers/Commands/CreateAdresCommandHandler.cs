using Klient.DAO.Commands;
using Klient.Model;
using Klient.Model.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
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
                Id = request.Model.Id,
                Miasto = request.Model.Miasto,
                Ulica = request.Model.Ulica,
                NrDomu = request.Model.NrDomu,
                NrMieszkania = request.Model.NrMieszkania

            };

            _dataContext.Adres.Add(adresEntity);

            await _dataContext.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }


    }
}
