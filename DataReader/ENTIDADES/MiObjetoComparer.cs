using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReader.ENTIDADES
{
    public class MiObjetoComparer : IEqualityComparer<ClienteEnt>
    {
        public bool Equals(ClienteEnt x, ClienteEnt y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }

            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
            {
                return false;
            }

            return x.cliente == y.cliente;
        }

        public int GetHashCode(ClienteEnt obj)
        {
            return obj.cliente.GetHashCode();
        }
    }
}
