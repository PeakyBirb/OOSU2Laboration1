using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
    public class BusinessManager
    {
        Repository.BokningRepository BokningR = new Repository.BokningRepository();
        Repository.BokRepository BokR = new Repository.BokRepository();
        Repository.ExpeditRepository ExpeditR = new Repository.ExpeditRepository();
        Repository.FakturaRepository FakturaR = new Repository.FakturaRepository();
        Repository.MedlemRepository MedlemR = new Repository.MedlemRepository();


        #region bokning
        
        public IEnumerable<Bokning> HämtaAllaBokningar()
        {
            return BokningR.HämtaAlla();
        }

        public Bokning HämtaBokningMedID(string Bokningsnummer)
        {
            return BokningR.HämtaMedID(Bokningsnummer);
        }

        public void UppdateraBokning(Bokning bokning)
        {
            BokningR.Uppdatera(bokning);
        }

        public void TaBortBokning(Bokning bokning)
        {
            BokningR.TaBort(bokning);
        }

        public void LäggTillBokning(Bokning bokning)
        {
            BokningR.LäggTill(bokning);
        }


        #endregion

        #region bok

        public IEnumerable<Bok> HämtaAllaBöcker()
        {
            return BokR.HämtaAlla();
        }

        public Bok HämtaBokMedID(string ISBNNummer)
        {
            return BokR.HämtaMedID(ISBNNummer);
        }

        public void UppdateraBok(Bok bok)
        {
            BokR.Uppdatera(bok);
        }

        public void TaBortBok(Bok bok)
        {
            BokR.TaBort(bok);
        }

        public void LäggTillBok(Bok bok)
        {
            BokR.LäggTill(bok);
        }


        #endregion

        #region expedit

        public IEnumerable<Expedit> HämtaAllaExpediter()
        {
            return ExpeditR.HämtaAlla();
        }

        public Expedit HämtaExpeditMedID(string Anställningsnummer)
        {
            return ExpeditR.HämtaMedID(Anställningsnummer);
        }

        public void UppdateraExpedit(Expedit expedit)
        {
            ExpeditR.Uppdatera(expedit);
        }

        public void TaBortExpedit(Expedit expedit)
        {
            ExpeditR.TaBort(expedit);
        }

        public void LäggTillExpedit(Expedit expedit)
        {
            ExpeditR.LäggTill(expedit);
        }


        #endregion
    }
}
