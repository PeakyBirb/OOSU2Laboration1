﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_layer.Repository
{
    internal class FakturaRepository : IRepository<Faktura>
    {
        List<Faktura> fakturorLista = new List<Faktura>();
        public Faktura HämtaMedID(string id)
        {
            foreach (Faktura faktura in fakturorLista)
            {
                if (faktura.FakturaNummer == id)
                {
                    Faktura hittadFaktura = faktura;
                    return hittadFaktura;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public IEnumerable<Faktura> HämtaAlla()
        {
            return fakturorLista;
        }

        public void LäggTill(Faktura faktura)
        {
            fakturorLista.Add(faktura);
        }

        public void TaBort(Faktura faktura)
        {
            fakturorLista.Remove(fakturorLista.SingleOrDefault(f => f.FakturaNummer == faktura.FakturaNummer));
        }

        public void Uppdatera(Faktura faktura)
        {
            fakturorLista.Remove(fakturorLista.SingleOrDefault(f => f.FakturaNummer == faktura.FakturaNummer));
            fakturorLista.Add(faktura);

        }
    }
}
