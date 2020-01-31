using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer.Repository
{
    internal class FakturaRepository : IRepository<Faktura>
    {
        Bokning Bokning { get; set; }

        public IEnumerable<Faktura> HämtaAlla()
        {
            throw new NotImplementedException();
        }

        public Faktura HämtaMedID(int ID)
        {
            throw new NotImplementedException();
        }

        public void LäggTill(Faktura entity)
        {
            throw new NotImplementedException();
        }

        public void TaBort(Faktura entity)
        {
            throw new NotImplementedException();
        }

        public void Uppdatera(Faktura entity)
        {
            throw new NotImplementedException();
        }
    }
}
