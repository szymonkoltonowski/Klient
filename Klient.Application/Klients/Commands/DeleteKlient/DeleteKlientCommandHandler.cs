using Klient.Core.Exceptions;
using Klient.DAO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Klient.Application.Klients.Commands.DeleteKlient
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
                throw new EntityNotFoundException(request.Id);
            }

            _dataContext.Klient.Remove(klientEntity);

            await _dataContext.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }




    }
}
