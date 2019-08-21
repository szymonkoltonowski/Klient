using Klient.DAO;
using Klient.Model.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.Application.Klients.Commands.CreateKlient
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
                Pesel = request.Pesel,
                Imie = request.Imie,
                Nazwisko = request.Nazwisko,
                AdresId = request.AdresId
            };

            _dataContext.Klient.Add(klientEntity);

            await _dataContext.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }

    }
}
