﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
	public class Medlem
	{
		private List<Bokning> bokningsLista;
		public List<Bokning> BokningsLista
		{
			get { return bokningsLista; }
			set { bokningsLista = value; }
		}

		private string medlemsNummer;
		public string MedlemsNummer
		{
			get { return medlemsNummer; }
			set { medlemsNummer = value; }
		}

		private string förNamn;
		public string FörNamn
		{
			get { return förNamn; }
			set { förNamn = value; }
		}
		private string efterNamn;
		public string EfterNamn
		{
			get { return efterNamn; }
			set { efterNamn = value; }
		}

		private string telefonnummer;
		public string Telefonnummer
		{
			get { return telefonnummer; }
			set { telefonnummer = value; }
		}

		private string epost;
		public string Epost
		{
			get { return epost; }
			set { epost = value; }
		}
		public string MedlemHeltNamn
		{
			get { return FörNamn + " " + EfterNamn; }
		}

		public Medlem(string medlemsnummer, string förnamn, string efternamn, string telefonnummer, string epost, List<Bokning> bokningsLista)
		{
			MedlemsNummer = medlemsnummer;
			FörNamn = förnamn;
			EfterNamn = efternamn;
			Telefonnummer = telefonnummer;
			Epost = epost;
			BokningsLista = bokningsLista;
		}

	}
}
