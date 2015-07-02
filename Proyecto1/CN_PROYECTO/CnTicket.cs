using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN_PROYECTO
{
    public class CnTicket
    {
        private int idTicket;
        private double price;
        private int currency;
        private String ticketState;
        private String idClient;
        private String idFlight;
        private int numSeat;

        public int IdTicket
        {
            get { return idTicket; }
            set { idTicket = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public String TicketState
        {
            get { return ticketState; }
            set { ticketState = value; }
        }

        public String IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }

        public String IdFlight
        {
            get { return idFlight; }
            set { idFlight = value; }
        }

        public int NumSeat
        {
            get { return numSeat; }
            set { numSeat = value; }
        }

        public void GuardarTickete(CnTicket tickete)
        {

            CD_PROYECTO.CdTicket ti = new CD_PROYECTO.CdTicket();
            ti.Price = tickete.Price;
            ti.Currency = tickete.Currency;
            ti.TicketState = tickete.TicketState;
            ti.IdClient = tickete.IdClient;
            ti.IdFlight = tickete.IdFlight;
            ti.NumSeat = tickete.NumSeat;

            ti.GuardarTickete(ti);
        }

        public void ModifyTickete(CnTicket tickete)
        {

            CD_PROYECTO.CdTicket ti = new CD_PROYECTO.CdTicket();
            ti.IdTicket = tickete.IdTicket;
            ti.Price = tickete.Price;
            ti.Currency = tickete.Currency;
            ti.TicketState = tickete.TicketState;
            ti.IdClient = tickete.IdClient;
            ti.IdFlight = tickete.IdFlight;
            ti.NumSeat = tickete.NumSeat;

            ti.ModifyTickete(ti);
        }
    }
}
