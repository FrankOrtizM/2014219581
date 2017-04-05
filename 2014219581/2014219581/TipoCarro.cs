using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581
{
    class TipoCarro
    {

        public enum TipoCarro { Bus, Auto}
        void auto()
         {
                var estadoActual = TipoCarro.Bus;

                switch (estadoActual)
                {
                    case TipoCarro.Bus:
                        Console.WriteLine("Es un bus");
                        break;
                    default:
                        Console.WriteLine("Es un auto");
                        break;

                }
         }
    }
}
