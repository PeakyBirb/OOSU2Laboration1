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
    public partial class Meny : Form
    {
        BusinessManager bm { get; set; }

        public Meny(BusinessManager BM)
        {
            InitializeComponent();
            bm = BM;
        }

        public void TillbakaTillLogin()
        {
            LogIn logIn = new LogIn(bm);
            logIn.Show();
            this.Hide();

        }

        private void TillbakaKnapp_Click(object sender, EventArgs e)
        {
            TillbakaTillLogin();
        }

        private void SkapaBokningKnapp_Click(object sender, EventArgs e)
        {
            SkapaBokning nySkapaBokning = new SkapaBokning(bm);
            nySkapaBokning.Show();

        }

        private void Meny_Load(object sender, EventArgs e)
        {

        }
    }
}
