using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
    class Bok : IRepository<Bok>
    {
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

		public void LäggTill(Bok entity)
		{
			throw new NotImplementedException();
		}

		public void TaBort(Bok entity)
		{
			throw new NotImplementedException();
		}

		public void Uppdatera(Bok entity)
		{
			throw new NotImplementedException();
		}

		public Bok HämtaMedID(int ID)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Bok> HämtaAlla()
		{
			throw new NotImplementedException();
		}
	}
}
