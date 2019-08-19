using Klient.DTO.Models;
using MediatR;
using System.Collections.Generic;

namespace Klient.Application.Adresses.Queries.GetAdres
{
    public class GetAdresQuery : IRequest<IEnumerable<AdresDTO>>
    {
    }
}
