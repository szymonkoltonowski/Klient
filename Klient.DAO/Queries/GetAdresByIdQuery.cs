using Klient.Model.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klient.DAO.Queries
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
