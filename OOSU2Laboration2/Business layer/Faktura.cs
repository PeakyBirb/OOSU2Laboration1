using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
    class Faktura
    {
		private string totalpris;
		public string Totalpris
		{
			get { return totalpris; }
			set { totalpris = value; }
		}

		private DateTime starttid;
		public DateTime Starttid
		{
			get { return starttid; }
			set { starttid = value; }
		}

		private DateTime sluttid;
		public DateTime Sluttid
		{
			get { return sluttid; }
			set { sluttid = value; }
		}

	}
}
