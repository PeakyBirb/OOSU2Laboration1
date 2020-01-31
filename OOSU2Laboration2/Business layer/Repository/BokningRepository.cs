using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer.Repository
{
    class BokningRepository
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
	}
}
