using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer.Repository
{
    internal class MedlemRepository : IRepository<Medlem>
    {
		private List<Bokning> bokningsLista;
		public List<Bokning> BokningsLista
		{
			get { return bokningsLista; }
			set { bokningsLista = value; }
		}

		public IEnumerable<Medlem> HämtaAlla()
		{
			throw new NotImplementedException();
		}

		public Medlem HämtaMedID(string ID)
		{
			throw new NotImplementedException();
		}

		public void LäggTill(Medlem entity)
		{
			throw new NotImplementedException();
		}

		public void TaBort(Medlem entity)
		{
			throw new NotImplementedException();
		}

		public void Uppdatera(Medlem entity)
		{
			throw new NotImplementedException();
		}
	}
}
