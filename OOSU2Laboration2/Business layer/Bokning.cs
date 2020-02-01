using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
    public class Bokning
    {
		Expedit Expedit { get; set; }

		private List<Faktura> fakturaLista;
		public List<Faktura> FakturaLista
		{
			get { return fakturaLista; }
			set { fakturaLista = value; }
		}


		Medlem Medlem { get; set; }

		private List<Bok> bokLista;
		public List<Bok> BokLista
		{
			get { return bokLista; }
			set { bokLista = value; }
		}


		private string bokningsNummer;
		public string BokningsNummer
		{
			get { return bokningsNummer; }
			set { bokningsNummer = value; }
		}

		private DateTime startDatum;
		public DateTime StartDatum
		{
			get { return startDatum; }
			set { startDatum = value; }
		}

		private DateTime slutDatum;
		public DateTime SlutDatum
		{
			get { return slutDatum; }
			set { slutDatum = value; }
		}

		private DateTime återlämningsDatum;
		public DateTime ÅterlämningsDatum
		{
			get { return återlämningsDatum; }
			set { återlämningsDatum = value; }
		}
	}
}
