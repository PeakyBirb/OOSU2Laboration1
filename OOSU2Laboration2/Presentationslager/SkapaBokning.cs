﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_layer;

namespace Presentationslager
{
    public partial class SkapaBokning : Form
    {
        BusinessManager bm { get; set; }

        public SkapaBokning(BusinessManager BM)
        {
            InitializeComponent();
            bm = BM;
            HämtaMedlemmarComboBox();
        }

        private void SkapaBokning_Load(object sender, EventArgs e)
        {

        }

        public void HämtaMedlemmarComboBox()
        {
            MedlemComboBox.DataSource = bm.HämtaAllaMedlemmar();
            MedlemComboBox.ValueMember = "MedlemsNummer";
            MedlemComboBox.DisplayMember = "MedlemHeltNamn";

        }

        public List<Bok> ListaTillgängligaBöcker(DateTime nyBokningStartDatum)
        {
            DateTime nyBokningSlutDatum = nyBokningStartDatum.AddDays(14);
            List<Bok> tillgängligaBöcker = new List<Bok>();
            
            foreach (var bok in bm.HämtaAllaBöcker())
            {
                if (bok.bokningsLista == null && bok.AntalKopior > 0)
                {
                    tillgängligaBöcker.Add(bok);
                }
            }

            foreach (var bokning in bm.HämtaAllaBokningar())
            {
                foreach (var bok in bokning.LånadeBöcker)
                {
                    if ((nyBokningStartDatum > bokning.SlutDatum) && (nyBokningSlutDatum < bokning.StartDatum) && (bok.AntalKopior > 0))
                    {
                        tillgängligaBöcker.Add(bok);

                    }
                }
            }

            

            return tillgängligaBöcker;
        }

        public void BokaValdaBöcker()
        {

            //böckerna
            List<Bok> valdaBöcker = new List<Bok>();

            foreach (Bok bok in LedigaBöckerListBox.SelectedItems)
            {
                valdaBöcker.Add(bok);
            }
            //medlemmen
            Medlem valdMedlem = (Medlem)MedlemComboBox.SelectedItem;

            //startdatum
            DateTime valtStartDatum = BokningsDatumVäljare.Value;

            //ta med expedit


            //bokningsnummer
            string nyttBokningsnummer = 

            //båda till bokning

            Bokning nyBokning = new Bokning();
            //räkna ner antalkopior
        }

        private void LedigaBöckerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SökDatumKnapp_Click(object sender, EventArgs e)
        {

            LedigaBöckerListBox.DataSource = ListaTillgängligaBöcker(BokningsDatumVäljare.Value);
            LedigaBöckerListBox.ValueMember = "ISBNNummer";
            LedigaBöckerListBox.DisplayMember = "BokTitelFörfattare";

        }


        private void BokningsDatumVäljare_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MedlemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BokaKnapp_Click(object sender, EventArgs e)
        {
            BokaValdaBöcker();
        }
    }
}
