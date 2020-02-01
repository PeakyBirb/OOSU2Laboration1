using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer.Repository
{
    internal class ExpeditRepository: IRepository<Expedit>
    {
		private List<Bokning> bokningsLista;
		public List<Bokning> BokningsLista
		{
			get { return bokningsLista; }
			set { bokningsLista = value; }
		}

		public IEnumerable<Expedit> HämtaAlla()
		{
			throw new NotImplementedException();
		}

		public Expedit HämtaMedID(string ID)
		{
			throw new NotImplementedException();
		}

		public void LäggTill(Expedit entity)
		{
			throw new NotImplementedException();
		}

		public void TaBort(Expedit entity)
		{
			throw new NotImplementedException();
		}

		public void Uppdatera(Expedit entity)
		{
			throw new NotImplementedException();
		}
	}
}
