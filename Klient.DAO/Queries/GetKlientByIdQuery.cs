﻿using Klient.Model.Entities;
using MediatR;
using System;


namespace Klient.DAO.Queries
{
    public class GetKlientByIdQuery : IRequest<KlientEntity>
    {
        public Guid _id;

        public GetKlientByIdQuery(Guid id)
        {
            _id = id;
        }
    }
}
