using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_layer.Repository
{
    internal class BokningRepository : IRepository<Bokning>
    {
		
		List<Bokning> bokningsLista = new List<Bokning>();

		

		public void LäggTill(Bokning bokning)
		{
			bokningsLista.Add(bokning);
		}

		public void TaBort(Bokning bokning)
		{
			bokningsLista.Remove(bokningsLista.SingleOrDefault(b => b.BokningsNummer == bokning.BokningsNummer));
		}

		public void Uppdatera(Bokning bokning)
		{
			bokningsLista.Remove(bokningsLista.SingleOrDefault(b => b.BokningsNummer == bokning.BokningsNummer));
			bokningsLista.Add(bokning);
		}

		public Bokning HämtaMedID(string ID)
		{
			if (bokningsLista != null)
			{

			foreach (Bokning bokning in bokningsLista)
			{
				if (bokning.BokningsNummer == ID)
				{
					Bokning hittadBokn = bokning;
					return hittadBokn;
				}
				else
				{
					return null;
				}
			}
			}
			return null;
		}

		public IEnumerable<Bokning> HämtaAlla()
		{
			return bokningsLista;
		}
	}
}
