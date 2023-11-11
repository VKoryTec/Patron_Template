using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter.Interfaces
{
    internal interface IBebidaHook //Sanchez Deseusa Victor Manuel 19211732
    {
        public sealed void PrepareRecipe()
        {
            Console.Clear();
            Descripcion();
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments();
            }
            else
                Console.WriteLine();
            ready();
        }
        void Descripcion();
        void brew();
        void addCondiments();
        private void boilWater()
        {
            Console.WriteLine("*Hirviendo agua*");
        }
        private void pourInCup()
        {
            Console.WriteLine("*Sirviendolo en una taza*");
        }
        private void ready()
        {
            Console.WriteLine("Maquina: \"Aqui tiene su bebida normal, tenga una bonita tarde\"");
        }
        bool customerWantsCondiments()
        {
            return true;
        }
        public sealed bool WhileOpcion()
        {
            while (true)
            {
                Console.Write("\nOpcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        return true;

                    case "2":
                        return false;

                    default:
                        int left = Console.CursorLeft;
                        int top = Console.CursorTop - 1;

                        Console.SetCursorPosition(left, top);
                        Console.Write(new string(' ', Console.WindowWidth));

                        Console.SetCursorPosition(left, top-1);
                        break;
                }
            }
        }
    }
}
