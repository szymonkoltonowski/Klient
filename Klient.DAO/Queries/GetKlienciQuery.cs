using Klient.Model.Entities;
using System.Collections.Generic;
using MediatR;


namespace Klient.DAO.Queries
{
    public class GetKlienciQuery : IRequest<IEnumerable<KlientEntity>>
    {
    }
}
