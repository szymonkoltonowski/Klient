using Klient.DTO.Models;
using MediatR;
using System;


namespace Klient.Application.Klients.Queries.GetKlientById
{
    public class GetKlientByIdQuery : IRequest<KlientDTO>
    {
        public Guid id;

        public GetKlientByIdQuery(Guid id)
        {
            this.id = id;
        }
    }
}
