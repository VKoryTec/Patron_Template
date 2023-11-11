using PatronAdapter.Clases;
using PatronAdapter.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        IBebidaHook Bebida; //Sanchez Deseusa Victor Manuel 19211732

        string opcion;
        bool loop = true;

        while (loop)
        {
            Console.Clear();
            Console.WriteLine("- - - Maquina Normal - - -");
            Console.WriteLine("\n¡¡Bienvenido!!");
            Console.WriteLine("\n*La maquina tiene 2 botones*");
            Console.WriteLine("\n [1] Café");
            Console.WriteLine(" [2] Té");
            Console.Write("\nQue boton pulsas? ");
            opcion = Console.ReadLine();

            loop = false;
            switch (opcion)
            {
                case "1":
                    Bebida = new Cafe();
                    Bebida.PrepareRecipe();

                    break;

                case "2":
                    Bebida = new Te();
                    Bebida.PrepareRecipe();
                    break;

                default:
                    loop = true;
                    Console.Write("\nNo Existe ese boton...");
                    Console.ReadKey();
                    break;
            }
        }

    }
}