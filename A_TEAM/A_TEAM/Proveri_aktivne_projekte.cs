using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace A_TEAM
{
    class Proveri_aktivne_projekte
    {
        System.Windows.Forms.Timer timer;
        Thread newThread;

        // --- konstruktor koji radi sa tajmerom ---
        public Proveri_aktivne_projekte(int sati)
        {
            setTimer(sati);
            newThread = new Thread(new ThreadStart(test));
            newThread.Start();
        }
        
        // --- Setujemo tajmer ----
        private void setTimer(int interval)
        {
            timer = new System.Windows.Forms.Timer();
            //timer.Interval = interval * 1000 * 3600; // sati
            timer.Interval = interval * 1000; // sekunde radi testiranja
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        // --- Funkcija koja se poziva kada timer istekne ---
        private void timer_Tick(object sender, EventArgs e)
        {
           
            // --- Ispitujemo da li je thread vec kreiran ---
             if (newThread != null)
             {
                 // --- Ispitujemo da li je thread aktivan ---
                 if (!newThread.IsAlive)
                 {
                     newThread = new Thread(new ThreadStart(test));
                     newThread.Start();
                 }
             }
             else
             {
                 newThread = new Thread(new ThreadStart(test));
                 newThread.Start();
             }

        }

        // --- Funkcija koja stopira tajmer ---
        public void stopTimer()
        {
            timer.Stop();
            //Thread lastThread = new Thread(new ThreadStart(lastCheckQueue));
            //lastThread.Start();
        }

        // --- Funkcija koja se izvrsava kao novi thread ---
        private void test()
        {
            MessageBox.Show("Istekao timer");
        }
    }
}
