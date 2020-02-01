using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer.Repository
{
    internal class BokRepository : IRepository<Bok>
    {
		private List<Bokning> bokningsLista;
		public List<Bokning> BokningsLista
		{
			get { return bokningsLista; }
			set { bokningsLista = value; }
		}

		public IEnumerable<Bok> HämtaAlla()
		{
			throw new NotImplementedException();
		}

		public Bok HämtaMedID(string ID)
		{
			throw new NotImplementedException();
		}

		public void LäggTill(Bok entity)
		{
			throw new NotImplementedException();
		}

		public void TaBort(Bok entity)
		{
			throw new NotImplementedException();
		}

		public void Uppdatera(Bok entity)
		{
			throw new NotImplementedException();
		}
	}
}
