using Klient.Model.Entities;
using System.Collections.Generic;
using MediatR;
using Klient.DTO.Models;

namespace Klient.Application.Klients.Queries.GetKlient
{
    public class GetKlienciQuery : IRequest<IEnumerable<KlientDTO>>
    {
    }
}
