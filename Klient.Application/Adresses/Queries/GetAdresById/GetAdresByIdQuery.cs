using Klient.Model.Entities;
using MediatR;
using System;

namespace Klient.Application.Adresses.Queries.GetAdresById
{
    public class GetAdresByIdQuery : IRequest<AdresEntity>
    {
        public Guid _id;

        public GetAdresByIdQuery(Guid id)
        {
            _id = id;
        }

    }
}
