using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
    interface IRepository<T>
    {
        void LäggTill(T entity);

        void TaBort(T entity);

        void Uppdatera(T entity);

        T HämtaMedID(int ID);

        IEnumerable<T> HämtaAlla();

    }
}
