using Klient.Core.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Klient.DAO;


namespace Klient.Application.Adresses.Commands.DeleteAdres

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
            var adresEntity = await _dataContext.Adres.FirstOrDefaultAsync(adres => adres.Id == request.Id, cancellationToken);

            if (adresEntity == null)
            {
                throw new EntityNotFoundException(request.Id);
             }

            _dataContext.Adres.Remove(adresEntity);

            await _dataContext.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }




    }
}
