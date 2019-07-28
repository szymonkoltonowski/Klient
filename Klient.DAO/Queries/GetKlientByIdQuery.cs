using System;
using System.Collections.Generic;
using System.Text;

namespace Klient.DAO.Queries
{
    public class GetKlientByIdQuery
    {
        private int _id;

        public GetKlientByIdQuery(int id)
        {
            _id = id;
        }
    }
}
