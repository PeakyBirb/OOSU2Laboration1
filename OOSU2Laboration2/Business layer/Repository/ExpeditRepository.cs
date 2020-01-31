using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer.Repository
{
    internal class ExpeditRepository
    {
		private List<Bokning> bokningsLista;
		public List<Bokning> BokningsLista
		{
			get { return bokningsLista; }
			set { bokningsLista = value; }
		}


	}
}
