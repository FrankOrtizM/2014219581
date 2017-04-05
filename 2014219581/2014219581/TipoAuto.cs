using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581
{
    class TipoAuto
    {
        public enum TipoAuto{ Sedan,PickUp,Coupe,HatchBack}
         void auto()
         {
                var autoActual = TipoAuto.Sedan;

                switch (autoActual)
                {
                    case TipoAuto.Sedan:
                        Console.WriteLine("Es un sedan");
                        break;
                    case TipoAuto.PickUp:
                        Console.WriteLine("Es un pickup"):
                        break;
                    case TipoAuto.Coupe:
                        Console.WriteLine("Es un Coupe"):
                        break;
                    case TipoAuto.HatchBack:
                        Console.WriteLine("Es un Hatchback"):
                        break;
                    default:
                        Console.WriteLine("Tipo de auto no definida");
                        break;

                }
         }
             

            

          }
    
}
