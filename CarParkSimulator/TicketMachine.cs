using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketMachine
    {
        private string message;

        public TicketMachine(string message)
        {
            this.message = message;
        }

        public void AssignCarPark()
        {

        }

        public void CarArrived()
        {

        }

        public void PrintTicket()
        {

        }

        public void ClearMessage()
        {
            this.message = "";
        }

        public string GetMessage()
        {
            return message;
        }
    }
}
