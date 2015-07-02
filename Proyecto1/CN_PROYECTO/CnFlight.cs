using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN_PROYECTO
{
    public class CnFlight
    {
        private int idFlight;
        private int idTicket;
        private int idPlane;
        private String origen;
        private String destino;
        private String horaPartida;

        private String horaLlegada;

        public int IdFlight
        {
            get { return idFlight; }
            set { idFlight = value; }
        }

        public int IdTicket
        {
            get { return idTicket; }
            set { idTicket = value; }
        }

        public int IdPlane
        {
            get { return idPlane; }
            set { idPlane = value; }
        }

        public String Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        public String Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public String HoraPartida
        {
            get { return horaPartida; }
            set { horaPartida = value; }
        }

        public String HoraLlegada
        {
            get { return horaLlegada; }
            set { horaLlegada = value; }
        }

        public void GuardarFlight(CnFlight vuelo)
        {

            CD_PROYECTO.CdFlight fl = new CD_PROYECTO.CdFlight();
            fl.IdTicket = vuelo.IdTicket;
            fl.IdPlane = vuelo.IdPlane;
            fl.Origen = vuelo.Origen;
            fl.Destino = vuelo.Destino;
            fl.HoraLlegada = vuelo.HoraLlegada;
            fl.HoraPartida = vuelo.HoraPartida;

            fl.GuardarTickete(fl);
        }

        public void ModifyFlight(CnFlight vuelo)
        {

            CD_PROYECTO.CdFlight fl = new CD_PROYECTO.CdFlight();
            fl.IdFlight = vuelo.idFlight;
            fl.IdTicket = vuelo.IdTicket;
            fl.IdPlane = vuelo.IdPlane;
            fl.Origen = vuelo.Origen;
            fl.Destino = vuelo.Destino;
            fl.HoraLlegada = vuelo.HoraLlegada;
            fl.HoraPartida = vuelo.HoraPartida;

            fl.ModifyTickete(fl);
        }

    }
}
