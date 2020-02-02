using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentationslager
{
    public partial class Meny : Form
    {
        public Meny()
        {
            InitializeComponent();
        }

        public void TillbakaTillLogin()
        {
            this.Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form is LogIn)
                {
                    form.Show();
                    break;
                }
            }
        }

        private void TillbakaKnapp_Click(object sender, EventArgs e)
        {
            TillbakaTillLogin();
        }
    }
}
