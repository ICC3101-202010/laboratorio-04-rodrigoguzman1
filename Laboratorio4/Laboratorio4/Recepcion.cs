using System;
namespace Laboratorio4
{
    public class Recepcion : Maquina
    {
        public Recepcion(int memoria, string nombre)
        {
            this.memoriaMaxima = memoria;
            this.nombre = nombre;
        }

        public override void Apagado()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Maquina de Recepción apagada\n");
        }

        public override void Encendido()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Maquina de Recepción encendida\n");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public override void Reinicio()
        {
            base.Reinicio();
            Console.WriteLine("Maquina de Recepción reiniciada\n");
        }
    }
}
