using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagement
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();

            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Start();

            dateTime.ValueChanged += DateTime_ValueChanged;

            //putData.Text = DateTime.Now.Day.ToString();
        }

        private void DateTime_ValueChanged(object sender, EventArgs e)
        {
            //putData.Text = dateTime.Value.Day.ToString();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            int ss = DateTime.Now.Second;

            string time = "";
            time += ss.ToString();
            timer.Text = time;

            if(ss == 30 || ss == 0)
            {
                listBoxN.Items.Add("New Item at refresh");
            }
        }

        private void rezervareMenu_Click(object sender, EventArgs e)
        {
            Rezervare pageRezervare = new Rezervare();
            pageRezervare.Show();
        }

        private void listaRezervariMenu_Click(object sender, EventArgs e)
        {
            ListaRezervari pageListaRezervari = new ListaRezervari();
            pageListaRezervari.Show();
        }
    }
}
