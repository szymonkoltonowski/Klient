using Klient.Model.Entities;
using MediatR;
using System.Collections.Generic;

namespace Klient.DAO.Queries
{
    public class GetAdresQuery : IRequest<IEnumerable<AdresEntity>>
    {
    }
}
