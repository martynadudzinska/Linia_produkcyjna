using Linia_produkcyjna.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Linia_produkcyjna
{
    public partial class Form1 : Form
    {
        PerformanceCounter cpu = new PerformanceCounter("Processor", "% PRocessor Time", "_Total");
        bool spalone;
        bool niezrobione;
        int czas;
        int interval;
        Random random = new Random();
        int temperatura;
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Resources.sky70;
            textBox1.Visible = true;
            login.Visible = true;
            haslo.Visible = true;
            enter.Visible = true;
            suwak.Visible = false;
            tort0.Visible = false;
            ciastko0.Visible = false;
            babeczka0.Visible = false;
            ciasto0.Visible = false;
            tort.Visible = false;
            ciastko.Visible = false;
            babeczka.Visible = false;
            ciasto.Visible = false;
            tortspalony.Visible = false;
            ciastkospalone.Visible = false;
            babeczkaspalona.Visible = false;
            ciastospalone.Visible = false;
            obecnoscTxt.Visible = false;
            radioButton.Visible = false;
            obecnoscTxt.Visible = false;
            radioButton.Visible = false;
            txtOdliczanie.Visible = false;
            radioButton.Checked = false;
            temperaturaTxt.Visible = false;
            textInfo.Visible = false;
            textWartości.Visible = false;
            textWiatrak.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;   
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            zuzycieText.Visible = false;
            spalone = false;
            niezrobione = false;
            czas = 30;
            temperatura = 180;
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (login.Text == "kremik" && haslo.Text == "1234")
            {
               
                Linia();
            }
            else
            {
                
                MessageBox.Show("Nieprawidłowe dane logowania!!!");
            }
        }
        private void logowanie ()
        {
            
            timerPieczenie.Stop();
            timerWybor.Stop();
            timerTemperatura.Stop();
            this.BackgroundImage = Resources.sky70;
            textBox1.Visible = true;
            login.Visible = true; login.Text = "login";
            haslo.Visible = true; haslo.Text = "haslo";
            enter.Visible = true;
            suwak.Visible = false;
            tort0.Visible = false;
            ciastko0.Visible = false;
            babeczka0.Visible = false;
            ciasto0.Visible = false;
            tort.Visible = false;
            ciastko.Visible = false;
            babeczka.Visible = false;
            ciasto.Visible = false;
            tortspalony.Visible = false;
            ciastkospalone.Visible = false;
            babeczkaspalona.Visible = false;
            ciastospalone.Visible = false;
            radioButton.Visible = false;
            txtOdliczanie.Visible = false;
            radioButton.Checked = false;
            temperaturaTxt.Visible = false;   
            textInfo.Visible = false;
            textWartości.Visible = false;
            textWiatrak.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            zuzycieText.Visible = false;
            temperatura = 180;
        }
        private void Linia ()
        {
            this.BackgroundImage =  Resources.mlp60poprawione;
            textBox1.Visible = false;
            login.Visible = false;
            haslo.Visible = false;
            enter.Visible = false;
            tort0.Visible = true;
            ciastko0.Visible = true;
            babeczka0.Visible = true;
            ciasto0.Visible = true;
            suwak.Visible = true;
            temperaturaTxt.Visible = true; temperaturaTxt.Text = "Temperatura pieca: " + temperatura.ToString();
            textInfo.Visible = true;
            timerWybor.Start();
            timerPomocniczy.Start();
            temperatura =180;
            timerTemperatura.Start();
            textWartości.Visible = true;
            textWiatrak.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            zuzycieText.Visible=true;
        }

        private void Wybor(object sender, EventArgs e)
        {
            tort.Location = new Point(550, 320); tort.Visible = false;
            tortspalony.Location = new Point(550, 320); tortspalony.Visible = false;
            ciastko.Location = new Point(560, 340); ciastko.Visible = false;
            ciastkospalone.Location = new Point(560, 340); ciastkospalone.Visible = false;
            babeczka.Location = new Point(570, 345); babeczka.Visible = false;
            babeczkaspalona.Location = new Point(570, 345); babeczkaspalona.Visible = false;
            ciasto.Location = new Point(570, 350); ciasto.Visible = false;
            ciastospalone.Location = new Point(570, 350); ciastospalone.Visible = false;
            if ((!spalone)&&(!niezrobione))
            {
                if (suwak.Value == 0) { ciastko.Visible = true; }
                else if (suwak.Value == 1) { babeczka.Visible = true; }
                else if (suwak.Value == 2) { tort.Visible = true; }
                else { ciasto.Visible = true; }
                timerPieczenie.Start();
            }
            else if (spalone)
            {
                if (suwak.Value == 0) { ciastkospalone.Visible = true; }
                else if (suwak.Value == 1) { babeczkaspalona.Visible = true; }
                else if (suwak.Value == 2) { tortspalony.Visible = true; }
                else { ciastospalone.Visible = true; }
                timerPieczenie.Start();
            }
            

        }

        private void Pieczenie(object sender, EventArgs e)
        {
            tort.Left -= 15;
            ciasto.Left -= 15;
            ciastko.Left -= 15;
            babeczka.Left -= 15;
            tortspalony.Left -= 15;
            ciastospalone.Left -= 15;
            ciastkospalone.Left -= 15;
            babeczkaspalona.Left -= 15;

           
        }

       

        private void Odliczanie(object sender, EventArgs e)
        {
            timerObecnosc.Stop();
            txtOdliczanie.Text = "00:" + czas.ToString();
            czas -= 1;
            if (txtOdliczanie.Text == "00:0")
            {
                timerOdliczanie.Stop();
                if (!radioButton.Checked)
                {
                    obecnoscTxt.Visible = false;
                    radioButton.Visible = false;
                    txtOdliczanie.Visible = false;
                    logowanie();
                    czas = 30;
                }
            }
           
        }

        private void pomocniczyFunkcja(object sender, EventArgs e)
        {
            timerPomocniczy.Stop();
            timerOdliczanie.Stop();
            obecnoscTxt.Visible = false;
            radioButton.Visible = false;
            txtOdliczanie.Visible = false;
            interval = random.Next(7000, 12000);
            timerObecnosc.Interval = interval;
            timerObecnosc.Start();
        }

        private void obecnoscFunkcja(object sender, EventArgs e)
        {
            timerObecnosc.Stop();
            txtOdliczanie.Text = "00:30";
            zuzycieText.Visible = false;
            obecnoscTxt.Visible = true;
            radioButton.Visible = true;
            txtOdliczanie.Visible = true;
            timerOdliczanie.Start();
            
        }

        private void checkedRadio(object sender, EventArgs e)
        {
          
            timerOdliczanie.Stop();
            czas = 30;
            radioButton.Checked = false;
            obecnoscTxt.Visible = false;
            radioButton.Visible = false;
            txtOdliczanie.Visible = false;
            zuzycieText.Visible = true;
            timerPomocniczy.Start();
        }

        private void temperaturaFunkcja(object sender, EventArgs e)
        {
            temperatura += 1;
            temperaturaTxt.Text = "Temperatura pieca: " + temperatura.ToString();
            if (temperatura < 180) { niezrobione = true; spalone = false; }
            else if (temperatura > 220) { spalone = true; niezrobione = false; }
            else { spalone = false; niezrobione = false; }
            int powerUsage = (int)cpu.NextValue();
            zuzycieText.Text = "Aktualne użycie procesora: "+powerUsage.ToString() + " %";
        }



        private void wiatrak10(object sender, EventArgs e)
        {
            temperatura -= 10;
            temperaturaTxt.Text = "Temperatura pieca: " + temperatura.ToString();
        }

        private void wiatrak20(object sender, EventArgs e)
        {
            temperatura -= 20;
            temperaturaTxt.Text = "Temperatura pieca: " + temperatura.ToString();
        }

        private void wiatrak30(object sender, EventArgs e)
        {
            temperatura -= 30;
            temperaturaTxt.Text = "Temperatura pieca: " + temperatura.ToString();
        }

        private void wiatrak40(object sender, EventArgs e)
        {
            temperatura -= 40;
            temperaturaTxt.Text = "Temperatura pieca: " + temperatura.ToString();
        }
    }
}
