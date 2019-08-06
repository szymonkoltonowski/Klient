using System;
using System.Collections.Generic;
using System.Text;

namespace Klient.Core.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException() 
            : base(String.Format("Nie znaleziono encji"))
        {
        }
        public EntityNotFoundException(Guid Id)
            : base(String.Format("Nie znaleziono encji z takim id: {0}", Id))
        {
        }

    }
}
