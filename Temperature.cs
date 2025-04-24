using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2425._4G.MouniriYousef.Meteo
{
    class Temperature
    {
        List<Temperatura> temperature = new List<Temperatura>();

        public void IsExpired()
        {
            foreach (var t in temperature)
            {
                
            }
        }
        /// <summary>
        /// Ritorna una lista di oggetti Temperatura che comunicherà con il frontend
        /// </summary>
        /// <returns></returns>
        public List<Temperatura> ViewTemperature()
        {
            
            foreach(var t in temperature)
            {
                if(t.Descrizione == null)
                {
                    t.Renew();
                }
                else
                {
                    if (t.IsExpired())//controllo se è scaduto
                    {
                        t.Renew();//uso il metodo Renew per aggiornare i dati
                    }
                }
                
                
                
            }
            return temperature;
        }

        public virtual void AddTemperature(Temperatura t)
        {
            temperature.Add(t);
        }
     


    }
}
