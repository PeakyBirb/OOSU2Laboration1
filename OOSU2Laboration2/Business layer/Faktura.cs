﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
    public class Faktura
    {
		Bokning faktureradBokning { get; set; }

		private string fakturaNummer;
		public string FakturaNummer
		{
			get { return fakturaNummer; }
			set { fakturaNummer = value; }
		}

		private string totalpris;
		public string Totalpris
		{
			get { return totalpris; }
			set { totalpris = value; }
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

		public Faktura(string fakturanummer, string totalpris, DateTime startDatum, DateTime förfallodatum, Bokning bokning)
		{
			FakturaNummer = fakturanummer;
			Totalpris = totalpris;
			StartDatum = startDatum;
			SlutDatum = förfallodatum;
			faktureradBokning = bokning;
		}
	}
}
