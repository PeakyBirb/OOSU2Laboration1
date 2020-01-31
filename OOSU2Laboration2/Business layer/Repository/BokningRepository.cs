using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer.Repository
{
    class BokningRepository : IRepository<Bokning>
    {
		private List<Bok> bokLista;
		public List<Bok> BokLista
		{
			get { return bokLista; }
			set { bokLista = value; }
		}

		private List<Bok> bokningsLista;
		public List<Bok> BokningsLista
		{
			get { return bokningsLista; }
			set { bokningsLista = value; }
		}

		Expedit Expedit { get; set; }

		private List<Faktura> fakturaLista;
		public List<Faktura> FakturaLista
		{
			get { return fakturaLista; }
			set { fakturaLista = value; }
		}


		Medlem Medlem { get; set; }

		public void LäggTill(Bokning entity)
		{
			throw new NotImplementedException();
		}

		public void TaBort(Bokning entity)
		{
			throw new NotImplementedException();
		}

		public void Uppdatera(Bokning entity)
		{
			throw new NotImplementedException();
		}

		public Bokning HämtaMedID(int ID)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Bokning> HämtaAlla()
		{
			throw new NotImplementedException();
		}
	}
}
