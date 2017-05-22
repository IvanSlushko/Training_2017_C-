using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTeleExchange.Classes
{
    public class Terminal
    {
        private int _number;
        private Port _terminalPort;
        private Guid _id;


        public int Number
        {
            get
            {
                return _number;
            }
        }


        public Terminal(int number, Port port)
        {
            _number = number;
            _terminalPort = port;
        }




    }
}
