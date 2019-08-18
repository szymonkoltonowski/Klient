using Klient.Model.Entities;
using System.Collections.Generic;
using MediatR;
using Klient.Application.Klients.Queries.GetKlientById;

namespace Klient.Application.Klients.Queries.GetKlient
{
    public class GetKlienciQuery : IRequest<IEnumerable<KlientEntity>>
    {
    }
}
