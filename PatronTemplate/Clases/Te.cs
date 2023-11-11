using PatronAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter.Clases
{
    public class Te : IBebidaHook //Sanchez Deseusa Victor Manuel 19211732
    {
        public void Descripcion()
        {
            Console.WriteLine("Maquina: \"Té verde en camino, tendra un coste de $44.99 pesos\"");
        }
        public void brew()
        {
            Console.WriteLine("*Agregando y revolviendo la bolsita de té*");
        }
        public void addCondiments()
        {
            Console.WriteLine("\n*Añadiendo endulzante extra*");
        }
        public bool customerWantsCondiments()
        {
                Console.WriteLine("\nMaquina: \"Desea añadir endulzante extra?\"");

                Console.WriteLine("\n[1] Claro!");
                Console.WriteLine("[2] No, gracias");

            IBebidaHook hook = this;
            return hook.WhileOpcion();
        }
    }
}
