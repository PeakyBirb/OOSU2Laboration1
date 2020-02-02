using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_layer.Repository
{
    internal class BokRepository : IRepository<Bok>
    {
		public List<Bok> bokLista = new List<Bok>();

		public void LäggTill(Bok bok)
		{
			bokLista.Add(bok);
		}

		public void TaBort(Bok bok)
		{
			bokLista.Remove(bokLista.SingleOrDefault(b => b.ISBNNummer == bok.ISBNNummer));
		}

		public void Uppdatera(Bok bok)
		{
			bokLista.Remove(bokLista.SingleOrDefault(b => b.ISBNNummer == bok.ISBNNummer));
			bokLista.Add(bok);
		}

		public Bok HämtaMedID(string ISBNNummer)
		{
			if (bokLista != null)
			{

				foreach (Bok bok in bokLista)
				{
					if (bok.ISBNNummer == ISBNNummer)
					{
						Bok hittadBok = bok;
						return hittadBok;
					}
					else
					{
						return null;
					}
				}
			}
			return null;
		}

		public IEnumerable<Bok> HämtaAlla()
		{
			return bokLista;
		}
	}
}
