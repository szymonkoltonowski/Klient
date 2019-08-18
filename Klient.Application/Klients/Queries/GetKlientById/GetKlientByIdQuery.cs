using Klient.Model.Entities;
using MediatR;
using System;


namespace Klient.Application.Klients.Queries.GetKlientById
{
    public class GetKlientByIdQuery : IRequest<KlientViewModel>
    {
        public Guid id;

        public GetKlientByIdQuery(Guid id)
        {
            this.id = id;
        }
    }
}
