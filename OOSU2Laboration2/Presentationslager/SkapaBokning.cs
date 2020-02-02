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

        public SkapaBokning()
        {
            InitializeComponent();
        }

        private void SkapaBokning_Load(object sender, EventArgs e)
        {

        }
    }
}
