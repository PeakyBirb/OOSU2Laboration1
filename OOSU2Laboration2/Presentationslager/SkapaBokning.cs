using System;
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
        }

        private void SkapaBokning_Load(object sender, EventArgs e)
        {

        }

        public List<Bok> ListaTillgängligaBöcker(DateTime nyBokningStartDatum)
        {
            DateTime nyBokningSlutDatum = nyBokningStartDatum.AddDays(14);
            List<Bok> tillgängligaBöcker = new List<Bok>();

            foreach (var bokning in bm.HämtaAllaBokningar())
            {
                foreach (var bok in bokning.LånadeBöcker)
                {
                    if ((nyBokningStartDatum > bokning.SlutDatum) && (nyBokningSlutDatum < bokning.StartDatum))
                    {
                        tillgängligaBöcker.Add(bok);

                    }
                }

            }

            foreach (var bok in bm.HämtaAllaBöcker())
            {
                if (bok.BokningsLista == null)
                {
                    tillgängligaBöcker.Add(bok);
                }
            }

            return tillgängligaBöcker;

            //hämta böcker som inte har bokningar också
        }

        private void LedigaBöckerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SökDatumKnapp_Click(object sender, EventArgs e)
        {

            LedigaBöckerListBox.DataSource = ListaTillgängligaBöcker(BokningsDatumVäljare.Value);
        }


        private void BokningsDatumVäljare_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
