using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581
{
    class Tipobus
    {

        public enum TipoBus{Publico, Privado}
         void auto()
         {
                var estadoActual = TipoBus.Privado;

                switch (estadoActual)
                {
                    case TipoBus.Publico:
                        Console.WriteLine("Es publico");
                        break;
                    case TipoBus.Privado:
                        Console.WriteLine("Es privado"):
                        break;
                    default:
                        Console.WriteLine("Tipo de bus no definida");
                        break;

                }
         }
             

            

          }
    }
}
