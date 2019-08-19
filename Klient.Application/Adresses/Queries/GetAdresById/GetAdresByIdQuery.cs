using Klient.DTO.Models;
using MediatR;
using System;

namespace Klient.Application.Adresses.Queries.GetAdresById
{
    public class GetAdresByIdQuery : IRequest<AdresDTO>
    {
        public Guid _id;

        public GetAdresByIdQuery(Guid id)
        {
            _id = id;
        }

    }
}
