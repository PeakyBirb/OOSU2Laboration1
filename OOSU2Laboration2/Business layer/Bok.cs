﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
    public class Bok 
    {


		public List<Bokning> bokningsLista = new List<Bokning>();


		private string ISBNnummer;
		public string ISBNNummer
		{
			get { return ISBNnummer; }
			set { ISBNnummer = value; }
		}

		private string titel;
		public string Titel
		{
			get { return titel; }
			set { titel = value; }
		}

		private string författare;
		public string Författare
		{
			get { return författare; }
			set { författare = value; }
		}


		private bool utlånad;
		public bool Utlånad
		{
			get { return utlånad; }
			set { utlånad = value; }
		}

		private int antalKopior;
		public int AntalKopior
		{
			get { return antalKopior; }
			set { antalKopior = value; }
		}

		public string BokTitelFörfattare
		{
			get { return Författare + " - " + Titel; }
		}

		public Bok(string isbnnummer, string titel, string författare, bool utlånad, int antalkopior, List<Bokning> BokningsLista)
		{
			ISBNNummer = isbnnummer;
			Titel = titel;
			Författare = författare;
			Utlånad = utlånad;
			AntalKopior = antalkopior;
			bokningsLista = BokningsLista;
		}

	}
}
