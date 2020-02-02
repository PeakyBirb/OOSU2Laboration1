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

        public ListaTillgängligaBöcker(DateTime nyBokningStartDatum)
        {
            

            foreach (var bokning in bm.HämtaAllaBokningar())
            {
                foreach (var bok in bokning.LånadeBöcker)
                {
                    if ((nyBokningStartDatum > bokning.SlutDatum) && (nyBokningSlutDatum < bokning.StartDatum))
                    {

                    }
                }

            }
        }

        private void LedigaBöckerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SökDatumKnapp_Click(object sender, EventArgs e)
        {
            ListaTillgängligaBöcker(BokningsDatumVäljare.Value);
        }


        private void BokningsDatumVäljare_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
