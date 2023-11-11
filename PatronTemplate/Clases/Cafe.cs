using PatronAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter.Clases
{
    public class Cafe : IBebidaHook //Sanchez Deseusa Victor Manuel 19211732
    {
        public void Descripcion()
        {
            Console.WriteLine("Maquina: \"Un cafe rojo en camino, tendra un coste de su ojo derecho :)...\n");
        }
        public void brew()
        {
            Console.WriteLine("*Exprimiendo y agregando sangre humana fresca*");
        }
        public void addCondiments()
        {
            Console.WriteLine("\n*Añadiendo azucar*");
        }
        public bool customerWantsCondiments()
        {
            Console.WriteLine("\nMaquina: \"Desea añadir....... Azucar?\"");

            Console.WriteLine("\n[1] Eh... claro");
            Console.WriteLine("[2] No, asi esta bien, solo quiero irme");

            IBebidaHook hook = this;
            return hook.WhileOpcion();
        }

    }
}
