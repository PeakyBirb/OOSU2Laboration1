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
    public partial class LogIn : Form
    {
        BusinessManager bm = new BusinessManager();

        public void SkapaExpedit()
        {
            Expedit nyExpedit = new Expedit("4756", "Birgitta", "Hansson", "cvbnm123", "Expedit");
            bm.LäggTillExpedit(nyExpedit);
        }

        public bool Inloggning(string ID, string lösenord)
        {
            var expediter = bm.HämtaAllaExpediter();


            if (ID != null || lösenord != null)
            {

                foreach (var expedit in expediter)
                {
                    if (ID == expedit.AnställningsNummer && lösenord == expedit.Lösenord)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                return false;
            }
            else return false;

        }


        public LogIn()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SkapaExpedit();
            anställningsnummerTextbox.Text = "4756";
            lösenordTextbox.Text = "cvbnm123";
        }

        private void anställningsnummerTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoggaInKnapp_Click(object sender, EventArgs e)
        {
            if (Inloggning(anställningsnummerTextbox.Text, lösenordTextbox.Text) == true)
            {
                Meny form = new Meny();
                form.Show();

                this.Hide();
            }
            else
            {
                labelLOGIN.Text = "Fel anställningsnummer eller lösenord! :(";
            }
            
        }

        private void lösenordTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
