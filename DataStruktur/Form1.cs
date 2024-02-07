using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStruktur
{
    //NB! hvis jeg skriver liste mener jeg egentlig array
    public partial class frmArray : Form
    {
        //Lager min array
        string[] colors = {"blue", "yellow", "red"};

        public frmArray()
        {
            InitializeComponent();
            update();//kaller update metoden som oppdaterer displayet
        }

        public void update()//lager en update() metode som kalles på når jeg vil oppdatere array visningen
        {
            //inni update()
            txtArrayDisplay.Text = string.Empty; //gjør displayet tomt
            for (int l = 0; l < colors.Length; l++) //for loopen, l=length, bruker denne til å gå gjennom hver punkt i arrayen (colors.length for å finne lengden(for å printe rett antall))
            {
                txtArrayDisplay.Text += colors[l] + "\r\n"; // legger til colors array til display, "\r\n" skifter linje
            }
        }

        //legg til
        private void btnLeggTil_Click(object sender, EventArgs e)//når trykket på legg til knappen
        {
            string newItem = txtLeggTil.Text; //legger til den nye item til en variabel
            colors = colors.Append(newItem).ToArray(); //her legger jeg til newItem til arrayen
            update();
        }

        private void btnNrLeggTil_Click(object sender, EventArgs e)//når legg til knaoo trykkes
        {
            int nr = int.Parse(txtNrLeggTil.Text); //gjør nummeret skrevet i txtNrLeggTil.text til int (konverteres med .parse())
            nr -= 1; //subtraherer 1 fra nr, for å få rett plassering (pga array starter på 0 istedenfor å starte på 1)

            if (nr >= 0 && nr <= colors.Length) //hvis nr er større eller det samme som 0 og nr er mindre en lengden på arrayen så:
            {
                string[] newColors = new string[colors.Length + 1]; //lager ny array som heter newColors, den skal ha en flære i lengden enn colors arrayen
                for (int i = 0, j = 0; j < newColors.Length; i++, j++) //for loop, her lager jeg to variabler, i holder styr på antall "i" colors arrayen, mens "j" holder styr på antall i den nye colors arrayen
                {//hvis j er mindre enn lengden til den nye arrayen skal loopen repiteres
                    // dett: i++, j++ sørger for at loopen stopper når arrayen er "ferdig" og det ikke er mer verdier inni 
                    if (j == nr) //hvis j er det samme som nummeret, dette er for å legge til riktig text på riktig plass
                    {
                        newColors[j] = txtTextLeggTil.Text;//legger til tekst på den rette plassen
                        i--;//fordi vi la til en verdi i den nye arrayen må vi gå tilbake ett hakk i den andre slik vi får med alle
                    }
                    else //hvis ikke:
                    {
                        newColors[j] = colors[i];//legg til neste verdi fra arrayen til den nye
                    }
                }
                colors = newColors;//til slutt endre verdien til arrayen med den nye arrayen for å ha med den nylig lagt til verdien
                update();//oppdater displayen
            }
        }
        
        //fjern

        private void btnSlettSiste_Click(object sender, EventArgs e)//hvis slett siste knapp trykkes
        {
            int l = colors.Length; //legger til lengden av arrayen til "l"
            colors = colors.Take(l-1).ToArray();//tar vekk den siste fra array med take(lengde på array minus 1)
            update();//oppdaterer displayen
        }

        private void btnSlett_Click(object sender, EventArgs e)
        {//denne koden er ganske lik den ene legg til tabellen, men istedenfor å legge til en spesifik plass, så fjerner vi fra en spesifik plass
            int nr = int.Parse(txtSlett.Text) - 1; //tar nummeret skrevet inn og subtraherer med 1 fordi array starter på 0

            if (nr >= 0 && nr < colors.Length)//hvis nr er større eller lik 0 og nr er mindre enn lengden på arrayen så:
            {
                string[] newColors = new string[colors.Length - 1]; //lager ny array som heter newcolors, legger til lengden -1 fordi vi skal fjerne en verdi
                for (int i = 0, j = 0; i < colors.Length; i++)//for loop, her lager jeg to variabler, "i" holder styr på antall i colors arrayen, mens "j" holder styr på antall i den nye colors listen
                {
                    if (i != nr) //skjekker om "i" er ikke lik nr
                    {//denne loopen kopierer over alle vedier utenom den som bruker skrev inn, som da leder til en array med 1 mindre verdi på plassen brukeren ville
                        newColors[j] = colors[i];
                        j++;
                    }
                }
                colors = newColors; //endrer colors til å inneholde hva som står i newColors
                update();//oppdaterer tabellen
            }
        }


        //exit
        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            Application.Exit(); //avslutter application
        }
    }
}
